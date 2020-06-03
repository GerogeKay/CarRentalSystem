using CRSBLL;
using MODEL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class AuditListForm : Form
    {
        AuditDal auditDal = new AuditDal();
        public AuditListForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshList();
        }

        // 刷新列表
        private void refreshList()
        {
            Cursor = Cursors.WaitCursor;
            List<AuditRequest> auditRequests = auditDal.GetAuditRequests(comboBox1.Text);
            if (auditRequests == null || auditRequests.Count == 0)
            {
                lvAuditList.BeginUpdate();
                lvAuditList.Items.Clear();
                lvAuditList.EndUpdate();
                Cursor = Cursors.Default;
                return;
            }
            lvAuditList.BeginUpdate();
            lvAuditList.Items.Clear();

            if (comboBox1.Text == "管理员注册")
            {
                colLicense.Width = 0;
                AdminInfo adminTemp;
                for (int i = 0; i < auditRequests.Count; i++)
                {
                    lvAuditList.Items.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    adminTemp = JsonConvert.DeserializeObject<AdminInfo>(auditRequests[i].Content);
                    lvAuditList.Items[i].SubItems[1].Text = auditRequests[i].Id.ToString();
                    lvAuditList.Items[i].SubItems[2].Text = adminTemp.AdminName;
                    lvAuditList.Items[i].SubItems[3].Text = adminTemp.AdminPhone;
                    lvAuditList.Items[i].SubItems[4].Text = adminTemp.AdminRealName;
                    lvAuditList.Items[i].SubItems[5].Text = adminTemp.AdminIdentity;
                    lvAuditList.Items[i].SubItems[6].Text = adminTemp.AdminAddress;
                    lvAuditList.Items[i].SubItems[7].Text = "";
                }
            }
            else if (comboBox1.Text == "用户注册")
            {
                colLicense.Width = 100;
                UserInfo userTemp;
                for (int i = 0; i < auditRequests.Count; i++)
                {
                    lvAuditList.Items.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    lvAuditList.Items[i].SubItems.Add("");
                    userTemp = JsonConvert.DeserializeObject<UserInfo>(auditRequests[i].Content);
                    lvAuditList.Items[i].SubItems[1].Text = auditRequests[i].Id.ToString();
                    lvAuditList.Items[i].SubItems[2].Text = userTemp.UserName;
                    lvAuditList.Items[i].SubItems[3].Text = userTemp.UserPhone;
                    lvAuditList.Items[i].SubItems[4].Text = userTemp.UserRealName;
                    lvAuditList.Items[i].SubItems[5].Text = userTemp.UserIdentity;
                    lvAuditList.Items[i].SubItems[6].Text = userTemp.UserAddress;
                    lvAuditList.Items[i].SubItems[7].Text = userTemp.UserDriLicense;
                }
            }
            lvAuditList.EndUpdate();
            Cursor = Cursors.Default;
        }

        private void lvAuditList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAuditList.SelectedItems.Count>0)
            {
                //string msg = lvAuditList.SelectedItems[0].SubItems[1].Text;
                //MessageBox.Show(msg);
            }
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            if (lvAuditList.SelectedItems.Count > 0)
            {
                int auditId = Convert.ToInt32(lvAuditList.SelectedItems[0].SubItems[1].Text);
                AuditCheck(auditId, true);
                refreshList();
            }
        }

        private void AuditCheck(int auditId, bool isPass)
        {
            AuditRequest request = auditDal.GetAuditRequestById(auditId);
            if (request!=null)
            {
                if (isPass)
                {
                    bool result = false;
                    switch (request.AuditType)
                    {
                        case "管理员注册":
                            AdminDal adminDal = new AdminDal();
                            result = adminDal.InsertAdmin(JsonConvert.DeserializeObject<AdminInfo>(request.Content));
                            break;
                        case "用户注册":
                            UserDal userDal = new UserDal();
                            result = userDal.InsertUser(JsonConvert.DeserializeObject<UserInfo>(request.Content));
                            break;
                        default:
                            break;
                    }
                    if (!result)
                    {
                        MessageBox.Show("审核通过失败");
                    }
                }
                request.AuditorId = StaticData.adminLocal.AdminId;
                request.IsPass = isPass;
                bool isCheck = auditDal.Audit_Check(request);
                if (!isCheck)
                {
                    MessageBox.Show("审核处理失败");
                }
            }
        }
    }
}

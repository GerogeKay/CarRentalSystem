namespace CarRentalSystem
{
    partial class AuditListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuditId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdentity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLicense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPass = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(385, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---审核列表---";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "管理员注册",
            "用户注册"});
            this.comboBox1.Location = new System.Drawing.Point(82, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "审核类型:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colAuditId,
            this.colName,
            this.colPhone,
            this.colRealName,
            this.colIdentity,
            this.colAddress,
            this.colLicense});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(864, 362);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // colAuditId
            // 
            this.colAuditId.Text = "审核号";
            this.colAuditId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colName
            // 
            this.colName.Text = "用户名";
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colName.Width = 100;
            // 
            // colPhone
            // 
            this.colPhone.Text = "电话号码";
            this.colPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhone.Width = 120;
            // 
            // colRealName
            // 
            this.colRealName.Text = "真实姓名";
            this.colRealName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRealName.Width = 80;
            // 
            // colIdentity
            // 
            this.colIdentity.Text = "身份证号";
            this.colIdentity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colIdentity.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.Text = "地址";
            this.colAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAddress.Width = 200;
            // 
            // colLicense
            // 
            this.colLicense.Text = "驾驶证号码";
            this.colLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLicense.Width = 100;
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(633, 57);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(75, 23);
            this.buttonPass.TabIndex = 4;
            this.buttonPass.Text = "通过";
            this.buttonPass.UseVisualStyleBackColor = true;
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(729, 57);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(75, 23);
            this.buttonReject.TabIndex = 5;
            this.buttonReject.Text = "不通过";
            this.buttonReject.UseVisualStyleBackColor = true;
            // 
            // AuditListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AuditListForm";
            this.Text = "AuditListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colAuditId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colRealName;
        private System.Windows.Forms.ColumnHeader colIdentity;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colLicense;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button buttonReject;
    }
}
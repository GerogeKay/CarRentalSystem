using CRSBLL;
using MODEL;
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
    public partial class ShowRentalOrder : Form
    {
        public ShowRentalOrder(RentalOrder order)
        {
            InitializeComponent();
            string StoreName = new StoreDal().StoreSelectById(order.StoreID).StoreName;
            string UserName = new UserDal().SelectUserByID(order.UserID).UserName;
            lbStoreName.Text += " " + StoreName;
            lbUserName.Text += " " + UserName;
            lbCarID.Text += " " + order.CarID;
            lbStartTime.Text += order.StartTime;
            lbEndTime.Text += order.EndTime;
            lbCost.Text += " " + order.OrderCost.ToString("C");
        }

        private void brtnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace CarRentalSystem
{
    partial class ShowRentalOrder
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
            this.lbStoreName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.brtnConfirm = new System.Windows.Forms.Button();
            this.lbCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStoreName
            // 
            this.lbStoreName.AutoSize = true;
            this.lbStoreName.Location = new System.Drawing.Point(55, 20);
            this.lbStoreName.Name = "lbStoreName";
            this.lbStoreName.Size = new System.Drawing.Size(47, 12);
            this.lbStoreName.TabIndex = 0;
            this.lbStoreName.Text = "店铺名:";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(55, 41);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(47, 12);
            this.lbCarID.TabIndex = 1;
            this.lbCarID.Text = "车辆ID:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(55, 63);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(47, 12);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "用户名:";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(55, 86);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(59, 12);
            this.lbStartTime.TabIndex = 3;
            this.lbStartTime.Text = "开始时间:";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Location = new System.Drawing.Point(55, 110);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(59, 12);
            this.lbEndTime.TabIndex = 4;
            this.lbEndTime.Text = "结束时间:";
            // 
            // brtnConfirm
            // 
            this.brtnConfirm.Location = new System.Drawing.Point(142, 175);
            this.brtnConfirm.Name = "brtnConfirm";
            this.brtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.brtnConfirm.TabIndex = 5;
            this.brtnConfirm.Text = "确定";
            this.brtnConfirm.UseVisualStyleBackColor = true;
            this.brtnConfirm.Click += new System.EventHandler(this.brtnConfirm_Click);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(55, 134);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(59, 12);
            this.lbCost.TabIndex = 6;
            this.lbCost.Text = "花费金额:";
            // 
            // ShowRentalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(343, 210);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.brtnConfirm);
            this.Controls.Add(this.lbEndTime);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.lbStoreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowRentalOrder";
            this.Text = "当前订单信息";
            this.Load += new System.EventHandler(this.ShowRentalOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStoreName;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Button brtnConfirm;
        private System.Windows.Forms.Label lbCost;
    }
}
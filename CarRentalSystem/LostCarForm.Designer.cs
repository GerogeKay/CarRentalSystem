namespace CarRentalSystem
{
    partial class LostCarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbCarType = new System.Windows.Forms.Label();
            this.lbCarPlateNumber = new System.Windows.Forms.Label();
            this.lbCarColor = new System.Windows.Forms.Label();
            this.lbLiquidatedDmg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPayPwd = new System.Windows.Forms.TextBox();
            this.lbCarStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(127, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---挂失车辆---";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 44);
            this.panel1.TabIndex = 5;
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(58, 61);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(53, 12);
            this.lbCarID.TabIndex = 6;
            this.lbCarID.Text = "车辆ID: ";
            // 
            // lbCarType
            // 
            this.lbCarType.AutoSize = true;
            this.lbCarType.Location = new System.Drawing.Point(46, 109);
            this.lbCarType.Name = "lbCarType";
            this.lbCarType.Size = new System.Drawing.Size(65, 12);
            this.lbCarType.TabIndex = 7;
            this.lbCarType.Text = "车辆型号: ";
            // 
            // lbCarPlateNumber
            // 
            this.lbCarPlateNumber.AutoSize = true;
            this.lbCarPlateNumber.Location = new System.Drawing.Point(46, 85);
            this.lbCarPlateNumber.Name = "lbCarPlateNumber";
            this.lbCarPlateNumber.Size = new System.Drawing.Size(65, 12);
            this.lbCarPlateNumber.TabIndex = 8;
            this.lbCarPlateNumber.Text = "车牌号码: ";
            // 
            // lbCarColor
            // 
            this.lbCarColor.AutoSize = true;
            this.lbCarColor.Location = new System.Drawing.Point(46, 134);
            this.lbCarColor.Name = "lbCarColor";
            this.lbCarColor.Size = new System.Drawing.Size(65, 12);
            this.lbCarColor.TabIndex = 9;
            this.lbCarColor.Text = "车辆颜色: ";
            // 
            // lbLiquidatedDmg
            // 
            this.lbLiquidatedDmg.AutoSize = true;
            this.lbLiquidatedDmg.Location = new System.Drawing.Point(46, 184);
            this.lbLiquidatedDmg.Name = "lbLiquidatedDmg";
            this.lbLiquidatedDmg.Size = new System.Drawing.Size(65, 12);
            this.lbLiquidatedDmg.TabIndex = 10;
            this.lbLiquidatedDmg.Text = "违约金额: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "支付密码:";
            // 
            // tbPayPwd
            // 
            this.tbPayPwd.Location = new System.Drawing.Point(111, 208);
            this.tbPayPwd.Name = "tbPayPwd";
            this.tbPayPwd.PasswordChar = '●';
            this.tbPayPwd.Size = new System.Drawing.Size(212, 21);
            this.tbPayPwd.TabIndex = 25;
            // 
            // lbCarStatus
            // 
            this.lbCarStatus.AutoSize = true;
            this.lbCarStatus.Location = new System.Drawing.Point(46, 159);
            this.lbCarStatus.Name = "lbCarStatus";
            this.lbCarStatus.Size = new System.Drawing.Size(65, 12);
            this.lbCarStatus.TabIndex = 9;
            this.lbCarStatus.Text = "车辆状态: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(101, 253);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // LostCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbPayPwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLiquidatedDmg);
            this.Controls.Add(this.lbCarStatus);
            this.Controls.Add(this.lbCarColor);
            this.Controls.Add(this.lbCarPlateNumber);
            this.Controls.Add(this.lbCarType);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LostCarForm";
            this.Text = "挂失车辆";
            this.Load += new System.EventHandler(this.LostCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarType;
        private System.Windows.Forms.Label lbCarPlateNumber;
        private System.Windows.Forms.Label lbCarColor;
        private System.Windows.Forms.Label lbLiquidatedDmg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPayPwd;
        private System.Windows.Forms.Label lbCarStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}
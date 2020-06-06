namespace CarRentalSystem
{
    partial class ReturnCarForm
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
            this.lbRemainTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.tbPayPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOrderType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRemainTime
            // 
            this.lbRemainTime.AutoSize = true;
            this.lbRemainTime.Location = new System.Drawing.Point(67, 150);
            this.lbRemainTime.Name = "lbRemainTime";
            this.lbRemainTime.Size = new System.Drawing.Size(59, 12);
            this.lbRemainTime.TabIndex = 28;
            this.lbRemainTime.Text = "剩余时间:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(126, 245);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.AutoSize = true;
            this.lbOrderStatus.Font = new System.Drawing.Font("宋体", 10F);
            this.lbOrderStatus.Location = new System.Drawing.Point(66, 217);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(70, 14);
            this.lbOrderStatus.TabIndex = 25;
            this.lbOrderStatus.Text = "目前状态:";
            // 
            // tbPayPwd
            // 
            this.tbPayPwd.Location = new System.Drawing.Point(132, 181);
            this.tbPayPwd.Name = "tbPayPwd";
            this.tbPayPwd.PasswordChar = '●';
            this.tbPayPwd.Size = new System.Drawing.Size(212, 21);
            this.tbPayPwd.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "支付密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "结束时间:";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(132, 112);
            this.dtEndTime.MinDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(212, 21);
            this.dtEndTime.TabIndex = 21;
            this.dtEndTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(132, 76);
            this.dtStartTime.MinDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(212, 21);
            this.dtStartTime.TabIndex = 20;
            this.dtStartTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "开始时间:";
            // 
            // lbOrderType
            // 
            this.lbOrderType.AutoSize = true;
            this.lbOrderType.Location = new System.Drawing.Point(67, 44);
            this.lbOrderType.Name = "lbOrderType";
            this.lbOrderType.Size = new System.Drawing.Size(59, 12);
            this.lbOrderType.TabIndex = 17;
            this.lbOrderType.Text = "租车类型:";
            // 
            // ReturnCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 308);
            this.Controls.Add(this.lbRemainTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbOrderStatus);
            this.Controls.Add(this.tbPayPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOrderType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnCarForm";
            this.Text = "确认还车";
            this.Load += new System.EventHandler(this.ReturnCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRemainTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.TextBox tbPayPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOrderType;
    }
}
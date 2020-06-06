namespace CarRentalSystem
{
    partial class ReletCarForm
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
            this.dtActualTime = new System.Windows.Forms.DateTimePicker();
            this.lbActualTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbPayPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNewEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRentalType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(450, 44);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(148, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---选择续租时长---";
            // 
            // dtActualTime
            // 
            this.dtActualTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtActualTime.Enabled = false;
            this.dtActualTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActualTime.Location = new System.Drawing.Point(151, 211);
            this.dtActualTime.Name = "dtActualTime";
            this.dtActualTime.Size = new System.Drawing.Size(212, 21);
            this.dtActualTime.TabIndex = 29;
            this.dtActualTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // lbActualTime
            // 
            this.lbActualTime.AutoSize = true;
            this.lbActualTime.Location = new System.Drawing.Point(62, 217);
            this.lbActualTime.Name = "lbActualTime";
            this.lbActualTime.Size = new System.Drawing.Size(83, 12);
            this.lbActualTime.TabIndex = 28;
            this.lbActualTime.Text = "实际到期时间:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(145, 276);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("宋体", 10F);
            this.lbTotal.Location = new System.Drawing.Point(85, 248);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 14);
            this.lbTotal.TabIndex = 25;
            this.lbTotal.Text = "总计费用:";
            // 
            // tbPayPwd
            // 
            this.tbPayPwd.Location = new System.Drawing.Point(151, 179);
            this.tbPayPwd.Name = "tbPayPwd";
            this.tbPayPwd.PasswordChar = '●';
            this.tbPayPwd.Size = new System.Drawing.Size(212, 21);
            this.tbPayPwd.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "支付密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "新到期时间:";
            // 
            // dtNewEndTime
            // 
            this.dtNewEndTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtNewEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNewEndTime.Location = new System.Drawing.Point(151, 143);
            this.dtNewEndTime.MinDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtNewEndTime.Name = "dtNewEndTime";
            this.dtNewEndTime.Size = new System.Drawing.Size(212, 21);
            this.dtNewEndTime.TabIndex = 21;
            this.dtNewEndTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtNewEndTime.ValueChanged += new System.EventHandler(this.dtNewEndTime_ValueChanged);
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(151, 107);
            this.dtEndTime.MinDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(212, 21);
            this.dtEndTime.TabIndex = 20;
            this.dtEndTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "原到期时间:";
            // 
            // cbRentalType
            // 
            this.cbRentalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentalType.Enabled = false;
            this.cbRentalType.FormattingEnabled = true;
            this.cbRentalType.Items.AddRange(new object[] {
            "时租",
            "日租",
            "周租",
            "月租",
            "季租",
            "年租"});
            this.cbRentalType.Location = new System.Drawing.Point(151, 72);
            this.cbRentalType.Name = "cbRentalType";
            this.cbRentalType.Size = new System.Drawing.Size(212, 20);
            this.cbRentalType.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "租车类型:";
            // 
            // ReletCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 329);
            this.Controls.Add(this.dtActualTime);
            this.Controls.Add(this.lbActualTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbPayPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNewEndTime);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRentalType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReletCarForm";
            this.Text = "续租";
            this.Load += new System.EventHandler(this.ReletCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtActualTime;
        private System.Windows.Forms.Label lbActualTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbPayPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNewEndTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRentalType;
        private System.Windows.Forms.Label label2;
    }
}
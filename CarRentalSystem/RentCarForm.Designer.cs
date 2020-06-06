namespace CarRentalSystem
{
    partial class RentCarForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRentalType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPayPwd = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbActualTime = new System.Windows.Forms.Label();
            this.dtActualTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Text = "---选择租车类型---";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 44);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "租车类型:";
            // 
            // cbRentalType
            // 
            this.cbRentalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentalType.FormattingEnabled = true;
            this.cbRentalType.Items.AddRange(new object[] {
            "时租",
            "日租",
            "周租",
            "月租",
            "季租",
            "年租"});
            this.cbRentalType.Location = new System.Drawing.Point(151, 76);
            this.cbRentalType.Name = "cbRentalType";
            this.cbRentalType.Size = new System.Drawing.Size(212, 20);
            this.cbRentalType.TabIndex = 5;
            this.cbRentalType.SelectedIndexChanged += new System.EventHandler(this.cbRentalType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "开始时间:";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(151, 147);
            this.dtEndTime.MinDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(212, 21);
            this.dtEndTime.TabIndex = 8;
            this.dtEndTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtEndTime.ValueChanged += new System.EventHandler(this.dtEndTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "结束时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "支付密码:";
            // 
            // tbPayPwd
            // 
            this.tbPayPwd.Location = new System.Drawing.Point(151, 183);
            this.tbPayPwd.Name = "tbPayPwd";
            this.tbPayPwd.PasswordChar = '●';
            this.tbPayPwd.Size = new System.Drawing.Size(212, 21);
            this.tbPayPwd.TabIndex = 11;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("宋体", 10F);
            this.lbTotal.Location = new System.Drawing.Point(85, 252);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 14);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "总计费用:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(145, 280);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbActualTime
            // 
            this.lbActualTime.AutoSize = true;
            this.lbActualTime.Location = new System.Drawing.Point(86, 221);
            this.lbActualTime.Name = "lbActualTime";
            this.lbActualTime.Size = new System.Drawing.Size(59, 12);
            this.lbActualTime.TabIndex = 15;
            this.lbActualTime.Text = "到期时间:";
            // 
            // dtActualTime
            // 
            this.dtActualTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtActualTime.Enabled = false;
            this.dtActualTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActualTime.Location = new System.Drawing.Point(151, 215);
            this.dtActualTime.Name = "dtActualTime";
            this.dtActualTime.Size = new System.Drawing.Size(212, 21);
            this.dtActualTime.TabIndex = 16;
            this.dtActualTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = " yyyy年 MM月 dd日 HH:mm:ss";
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(151, 111);
            this.dtStartTime.MinDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(212, 21);
            this.dtStartTime.TabIndex = 7;
            this.dtStartTime.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dtStartTime.ValueChanged += new System.EventHandler(this.dtStartTime_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RentCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 329);
            this.Controls.Add(this.dtActualTime);
            this.Controls.Add(this.lbActualTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbPayPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRentalType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentCarForm";
            this.Text = "租车信息";
            this.Load += new System.EventHandler(this.RentCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRentalType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPayPwd;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbActualTime;
        private System.Windows.Forms.DateTimePicker dtActualTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace CarRentalSystem
{
    partial class AddRuleForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttoncomfirm = new System.Windows.Forms.Button();
            this.textHourCost = new System.Windows.Forms.TextBox();
            this.textDayCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUserLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textWeekCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSeasonCost = new System.Windows.Forms.TextBox();
            this.textMonthCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textYearCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(206, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttoncomfirm
            // 
            this.buttoncomfirm.Location = new System.Drawing.Point(72, 239);
            this.buttoncomfirm.Name = "buttoncomfirm";
            this.buttoncomfirm.Size = new System.Drawing.Size(75, 23);
            this.buttoncomfirm.TabIndex = 12;
            this.buttoncomfirm.Text = "确定";
            this.buttoncomfirm.UseVisualStyleBackColor = true;
            this.buttoncomfirm.Click += new System.EventHandler(this.buttoncomfirm_Click);
            // 
            // textHourCost
            // 
            this.textHourCost.Location = new System.Drawing.Point(104, 62);
            this.textHourCost.Name = "textHourCost";
            this.textHourCost.Size = new System.Drawing.Size(208, 21);
            this.textHourCost.TabIndex = 6;
            // 
            // textDayCost
            // 
            this.textDayCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDayCost.Location = new System.Drawing.Point(104, 90);
            this.textDayCost.Name = "textDayCost";
            this.textDayCost.Size = new System.Drawing.Size(208, 21);
            this.textDayCost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "时租费用:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "日租费用:";
            // 
            // textUserLevel
            // 
            this.textUserLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textUserLevel.Location = new System.Drawing.Point(104, 35);
            this.textUserLevel.Name = "textUserLevel";
            this.textUserLevel.Size = new System.Drawing.Size(208, 21);
            this.textUserLevel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "用户等级:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "周租费用:";
            // 
            // textWeekCost
            // 
            this.textWeekCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textWeekCost.Location = new System.Drawing.Point(104, 117);
            this.textWeekCost.Name = "textWeekCost";
            this.textWeekCost.Size = new System.Drawing.Size(208, 21);
            this.textWeekCost.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "季租费用:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "月租费用:";
            // 
            // textSeasonCost
            // 
            this.textSeasonCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textSeasonCost.Location = new System.Drawing.Point(104, 172);
            this.textSeasonCost.Name = "textSeasonCost";
            this.textSeasonCost.Size = new System.Drawing.Size(208, 21);
            this.textSeasonCost.TabIndex = 10;
            // 
            // textMonthCost
            // 
            this.textMonthCost.Location = new System.Drawing.Point(104, 144);
            this.textMonthCost.Name = "textMonthCost";
            this.textMonthCost.Size = new System.Drawing.Size(208, 21);
            this.textMonthCost.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "年租费用:";
            // 
            // textYearCost
            // 
            this.textYearCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textYearCost.Location = new System.Drawing.Point(104, 199);
            this.textYearCost.Name = "textYearCost";
            this.textYearCost.Size = new System.Drawing.Size(208, 21);
            this.textYearCost.TabIndex = 11;
            // 
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(350, 272);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttoncomfirm);
            this.Controls.Add(this.textMonthCost);
            this.Controls.Add(this.textHourCost);
            this.Controls.Add(this.textYearCost);
            this.Controls.Add(this.textSeasonCost);
            this.Controls.Add(this.textDayCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textWeekCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUserLevel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRuleForm";
            this.Text = "添加规则";
            this.Load += new System.EventHandler(this.AddRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttoncomfirm;
        private System.Windows.Forms.TextBox textHourCost;
        private System.Windows.Forms.TextBox textDayCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUserLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textWeekCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSeasonCost;
        private System.Windows.Forms.TextBox textMonthCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textYearCost;
    }
}
namespace CarRentalSystem
{
    partial class AddCarForm
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
            this.textCarType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPlateNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCarColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStoreList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(224, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttoncomfirm
            // 
            this.buttoncomfirm.Location = new System.Drawing.Point(90, 160);
            this.buttoncomfirm.Name = "buttoncomfirm";
            this.buttoncomfirm.Size = new System.Drawing.Size(75, 23);
            this.buttoncomfirm.TabIndex = 10;
            this.buttoncomfirm.Text = "确定";
            this.buttoncomfirm.UseVisualStyleBackColor = true;
            this.buttoncomfirm.Click += new System.EventHandler(this.buttoncomfirm_Click);
            // 
            // textCarType
            // 
            this.textCarType.Location = new System.Drawing.Point(116, 55);
            this.textCarType.Name = "textCarType";
            this.textCarType.Size = new System.Drawing.Size(208, 21);
            this.textCarType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "车辆型号:";
            // 
            // textPlateNumber
            // 
            this.textPlateNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPlateNumber.Location = new System.Drawing.Point(116, 28);
            this.textPlateNumber.Name = "textPlateNumber";
            this.textPlateNumber.Size = new System.Drawing.Size(208, 21);
            this.textPlateNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "车牌号码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "车辆颜色:";
            // 
            // textCarColor
            // 
            this.textCarColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCarColor.Location = new System.Drawing.Point(116, 83);
            this.textCarColor.Name = "textCarColor";
            this.textCarColor.Size = new System.Drawing.Size(208, 21);
            this.textCarColor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "所属店铺:";
            // 
            // cbStoreList
            // 
            this.cbStoreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStoreList.FormattingEnabled = true;
            this.cbStoreList.Location = new System.Drawing.Point(116, 110);
            this.cbStoreList.Name = "cbStoreList";
            this.cbStoreList.Size = new System.Drawing.Size(208, 20);
            this.cbStoreList.TabIndex = 12;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(375, 205);
            this.Controls.Add(this.cbStoreList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttoncomfirm);
            this.Controls.Add(this.textCarType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCarColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPlateNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCarForm";
            this.Text = "录入车辆";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttoncomfirm;
        private System.Windows.Forms.TextBox textCarType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPlateNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCarColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStoreList;
    }
}
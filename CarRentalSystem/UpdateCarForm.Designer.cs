namespace CarRentalSystem
{
    partial class UpdateCarForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.labelCarID = new System.Windows.Forms.Label();
            this.cbStoreList = new System.Windows.Forms.ComboBox();
            this.textCarType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCarColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPlateNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(86, 178);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.Location = new System.Drawing.Point(51, 35);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(47, 12);
            this.labelCarID.TabIndex = 17;
            this.labelCarID.Text = "车辆ID:";
            // 
            // cbStoreList
            // 
            this.cbStoreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStoreList.FormattingEnabled = true;
            this.cbStoreList.Location = new System.Drawing.Point(115, 139);
            this.cbStoreList.Name = "cbStoreList";
            this.cbStoreList.Size = new System.Drawing.Size(208, 20);
            this.cbStoreList.TabIndex = 10;
            // 
            // textCarType
            // 
            this.textCarType.Location = new System.Drawing.Point(115, 84);
            this.textCarType.Name = "textCarType";
            this.textCarType.Size = new System.Drawing.Size(208, 21);
            this.textCarType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "所属店铺:";
            // 
            // textCarColor
            // 
            this.textCarColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCarColor.Location = new System.Drawing.Point(115, 112);
            this.textCarColor.Name = "textCarColor";
            this.textCarColor.Size = new System.Drawing.Size(208, 21);
            this.textCarColor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "车辆型号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "车辆颜色:";
            // 
            // textPlateNumber
            // 
            this.textPlateNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPlateNumber.Location = new System.Drawing.Point(115, 57);
            this.textPlateNumber.Name = "textPlateNumber";
            this.textPlateNumber.Size = new System.Drawing.Size(208, 21);
            this.textPlateNumber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "车牌号码:";
            // 
            // UpdateCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(372, 232);
            this.Controls.Add(this.cbStoreList);
            this.Controls.Add(this.textCarType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCarColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPlateNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelCarID);
            this.Name = "UpdateCarForm";
            this.Text = "修改车辆信息";
            this.Load += new System.EventHandler(this.UpdateCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label labelCarID;
        private System.Windows.Forms.ComboBox cbStoreList;
        private System.Windows.Forms.TextBox textCarType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCarColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPlateNumber;
        private System.Windows.Forms.Label label6;
    }
}
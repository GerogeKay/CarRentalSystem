namespace CarRentalSystem
{
    partial class AddStoreFrom
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
            this.textStoreName = new System.Windows.Forms.TextBox();
            this.textStoreAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttoncomfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "店铺名称:";
            // 
            // textStoreName
            // 
            this.textStoreName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textStoreName.Location = new System.Drawing.Point(110, 39);
            this.textStoreName.Name = "textStoreName";
            this.textStoreName.Size = new System.Drawing.Size(208, 21);
            this.textStoreName.TabIndex = 1;
            // 
            // textStoreAddress
            // 
            this.textStoreAddress.Location = new System.Drawing.Point(110, 66);
            this.textStoreAddress.Name = "textStoreAddress";
            this.textStoreAddress.Size = new System.Drawing.Size(208, 21);
            this.textStoreAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "店铺地址:";
            // 
            // buttoncomfirm
            // 
            this.buttoncomfirm.Location = new System.Drawing.Point(92, 109);
            this.buttoncomfirm.Name = "buttoncomfirm";
            this.buttoncomfirm.Size = new System.Drawing.Size(75, 23);
            this.buttoncomfirm.TabIndex = 4;
            this.buttoncomfirm.Text = "确定";
            this.buttoncomfirm.UseVisualStyleBackColor = true;
            this.buttoncomfirm.Click += new System.EventHandler(this.buttoncomfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(226, 109);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddStoreFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(375, 165);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttoncomfirm);
            this.Controls.Add(this.textStoreAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textStoreName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStoreFrom";
            this.Text = "添加店铺";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStoreName;
        private System.Windows.Forms.TextBox textStoreAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttoncomfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}
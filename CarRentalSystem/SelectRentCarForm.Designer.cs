namespace CarRentalSystem
{
    partial class SelectRentCarForm
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
            this.lvCarList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlateNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(332, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---选择车辆---";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 44);
            this.panel1.TabIndex = 3;
            // 
            // lvCarList
            // 
            this.lvCarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colCarId,
            this.colPlateNumber,
            this.colCarType,
            this.colColor,
            this.colStoreName});
            this.lvCarList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCarList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvCarList.FullRowSelect = true;
            this.lvCarList.GridLines = true;
            this.lvCarList.HideSelection = false;
            this.lvCarList.Location = new System.Drawing.Point(0, 85);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(805, 365);
            this.lvCarList.TabIndex = 4;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // colCarId
            // 
            this.colCarId.Text = "车辆ID";
            this.colCarId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCarId.Width = 100;
            // 
            // colPlateNumber
            // 
            this.colPlateNumber.Text = "车牌号";
            this.colPlateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPlateNumber.Width = 100;
            // 
            // colCarType
            // 
            this.colCarType.Text = "车辆型号";
            this.colCarType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCarType.Width = 132;
            // 
            // colColor
            // 
            this.colColor.Text = "颜色";
            this.colColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colColor.Width = 83;
            // 
            // colStoreName
            // 
            this.colStoreName.Text = "所属店铺";
            this.colStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreName.Width = 381;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshList.Location = new System.Drawing.Point(637, 56);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshList.TabIndex = 11;
            this.buttonRefreshList.Text = "刷新";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCar.Location = new System.Drawing.Point(718, 56);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCar.TabIndex = 9;
            this.btnSelectCar.Text = "租车";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // RentCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.lvCarList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentCarForm";
            this.Text = "租车";
            this.Activated += new System.EventHandler(this.RentCarForm_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colCarId;
        private System.Windows.Forms.ColumnHeader colPlateNumber;
        private System.Windows.Forms.ColumnHeader colCarType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colStoreName;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Button btnSelectCar;
    }
}
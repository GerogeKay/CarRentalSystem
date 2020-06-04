namespace CarRentalSystem
{
    partial class CarManageForm
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
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectType = new System.Windows.Forms.ComboBox();
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoreID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Text = "---车辆信息---";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 2;
            // 
            // lvCarList
            // 
            this.lvCarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colCarId,
            this.colPlateNumber,
            this.colCarType,
            this.colColor,
            this.colStoreID,
            this.colUserID,
            this.colStatus});
            this.lvCarList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCarList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvCarList.FullRowSelect = true;
            this.lvCarList.GridLines = true;
            this.lvCarList.HideSelection = false;
            this.lvCarList.Location = new System.Drawing.Point(0, 85);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(800, 365);
            this.lvCarList.TabIndex = 3;
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
            this.colCarType.Width = 100;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshList.Location = new System.Drawing.Point(535, 56);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshList.TabIndex = 8;
            this.buttonRefreshList.Text = "刷新";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCar.Location = new System.Drawing.Point(697, 56);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateCar.TabIndex = 7;
            this.btnUpdateCar.Text = "修改车辆信息";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCar.Location = new System.Drawing.Point(616, 56);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "添加车辆";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "查询类型:";
            // 
            // cbSelectType
            // 
            this.cbSelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectType.FormattingEnabled = true;
            this.cbSelectType.Items.AddRange(new object[] {
            "全部车辆",
            "当前店铺"});
            this.cbSelectType.Location = new System.Drawing.Point(77, 58);
            this.cbSelectType.Name = "cbSelectType";
            this.cbSelectType.Size = new System.Drawing.Size(134, 20);
            this.cbSelectType.TabIndex = 10;
            this.cbSelectType.SelectedIndexChanged += new System.EventHandler(this.cbSelectType_SelectedIndexChanged);
            // 
            // colColor
            // 
            this.colColor.Text = "颜色";
            this.colColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colStoreID
            // 
            this.colStoreID.Text = "所属店铺";
            this.colStoreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreID.Width = 100;
            // 
            // colUserID
            // 
            this.colUserID.Text = "当前借用人ID";
            this.colUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUserID.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.Text = "当前状态";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 100;
            // 
            // CarManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSelectType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lvCarList);
            this.Controls.Add(this.panel1);
            this.Name = "CarManageForm";
            this.Text = "车辆管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colCarId;
        private System.Windows.Forms.ColumnHeader colPlateNumber;
        private System.Windows.Forms.ColumnHeader colCarType;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colStoreID;
        private System.Windows.Forms.ColumnHeader colUserID;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}
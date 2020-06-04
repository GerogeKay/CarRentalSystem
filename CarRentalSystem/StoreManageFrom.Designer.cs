namespace CarRentalSystem
{
    partial class StoreManageFrom
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
            this.lvStoreList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoreId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoreAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.buttonUpdateStore = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
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
            this.label1.Text = "---店铺列表---";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 1;
            // 
            // lvStoreList
            // 
            this.lvStoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colStoreId,
            this.colStoreName,
            this.colStoreAddress});
            this.lvStoreList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvStoreList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvStoreList.FullRowSelect = true;
            this.lvStoreList.GridLines = true;
            this.lvStoreList.HideSelection = false;
            this.lvStoreList.Location = new System.Drawing.Point(0, 85);
            this.lvStoreList.Name = "lvStoreList";
            this.lvStoreList.Size = new System.Drawing.Size(800, 365);
            this.lvStoreList.TabIndex = 2;
            this.lvStoreList.UseCompatibleStateImageBehavior = false;
            this.lvStoreList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // colStoreId
            // 
            this.colStoreId.Text = "店铺ID";
            this.colStoreId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreId.Width = 100;
            // 
            // colStoreName
            // 
            this.colStoreName.Text = "店铺名";
            this.colStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreName.Width = 150;
            // 
            // colStoreAddress
            // 
            this.colStoreAddress.Text = "店铺地址";
            this.colStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreAddress.Width = 400;
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStore.Location = new System.Drawing.Point(616, 56);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStore.TabIndex = 3;
            this.buttonAddStore.Text = "添加店铺";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // buttonUpdateStore
            // 
            this.buttonUpdateStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateStore.Location = new System.Drawing.Point(697, 56);
            this.buttonUpdateStore.Name = "buttonUpdateStore";
            this.buttonUpdateStore.Size = new System.Drawing.Size(91, 23);
            this.buttonUpdateStore.TabIndex = 4;
            this.buttonUpdateStore.Text = "修改店铺信息";
            this.buttonUpdateStore.UseVisualStyleBackColor = true;
            this.buttonUpdateStore.Click += new System.EventHandler(this.buttonUpdateStore_Click);
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshList.Location = new System.Drawing.Point(535, 56);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshList.TabIndex = 5;
            this.buttonRefreshList.Text = "刷新";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // StoreManageFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.buttonUpdateStore);
            this.Controls.Add(this.buttonAddStore);
            this.Controls.Add(this.lvStoreList);
            this.Controls.Add(this.panel1);
            this.Name = "StoreManageFrom";
            this.Text = "店铺信息管理";
            this.Activated += new System.EventHandler(this.StoreManageFrom_Activated);
            this.Load += new System.EventHandler(this.StoreManageFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvStoreList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colStoreId;
        private System.Windows.Forms.ColumnHeader colStoreName;
        private System.Windows.Forms.ColumnHeader colStoreAddress;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.Button buttonUpdateStore;
        private System.Windows.Forms.Button buttonRefreshList;
    }
}
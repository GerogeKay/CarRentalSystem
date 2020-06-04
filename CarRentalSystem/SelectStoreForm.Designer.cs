namespace CarRentalSystem
{
    partial class SelectStoreForm
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
            this.btnSelectStore = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(351, 18);
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
            this.panel1.Size = new System.Drawing.Size(833, 44);
            this.panel1.TabIndex = 1;
            // 
            // lvStoreList
            // 
            this.lvStoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colStoreId,
            this.colStoreName,
            this.colStoreAddress});
            this.lvStoreList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvStoreList.FullRowSelect = true;
            this.lvStoreList.GridLines = true;
            this.lvStoreList.HideSelection = false;
            this.lvStoreList.Location = new System.Drawing.Point(0, 43);
            this.lvStoreList.Name = "lvStoreList";
            this.lvStoreList.Size = new System.Drawing.Size(833, 381);
            this.lvStoreList.TabIndex = 3;
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
            this.colStoreName.Width = 208;
            // 
            // colStoreAddress
            // 
            this.colStoreAddress.Text = "店铺地址";
            this.colStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreAddress.Width = 498;
            // 
            // btnSelectStore
            // 
            this.btnSelectStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectStore.Location = new System.Drawing.Point(740, 434);
            this.btnSelectStore.Name = "btnSelectStore";
            this.btnSelectStore.Size = new System.Drawing.Size(75, 23);
            this.btnSelectStore.TabIndex = 4;
            this.btnSelectStore.Text = "选择";
            this.btnSelectStore.UseVisualStyleBackColor = true;
            this.btnSelectStore.Click += new System.EventHandler(this.btnSelectStore_Click);
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshList.Location = new System.Drawing.Point(659, 434);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshList.TabIndex = 6;
            this.buttonRefreshList.Text = "刷新";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // SelectStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 465);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.btnSelectStore);
            this.Controls.Add(this.lvStoreList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectStoreForm";
            this.Text = "店铺选择";
            this.Activated += new System.EventHandler(this.SelectStoreForm_Activated);
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
        private System.Windows.Forms.Button btnSelectStore;
        private System.Windows.Forms.Button buttonRefreshList;
    }
}
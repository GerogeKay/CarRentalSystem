namespace CarRentalSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.租车还车系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租车ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还车ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂失ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租还车查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.充值查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扣费规则管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.店铺信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审核列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.充值系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DevicePanel = new System.Windows.Forms.Panel();
            this.btnSelectStore = new System.Windows.Forms.Button();
            this.DevicePictureBox = new System.Windows.Forms.PictureBox();
            this.storeAddrLabel = new System.Windows.Forms.Label();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.DeviceIDLabel = new System.Windows.Forms.Label();
            this.LostCarButton = new System.Windows.Forms.Button();
            this.returnCarButton = new System.Windows.Forms.Button();
            this.rentCarButton = new System.Windows.Forms.Button();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.Moneylabel = new System.Windows.Forms.Label();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.InfoListPanel = new System.Windows.Forms.Panel();
            this.InfoListView = new System.Windows.Forms.ListView();
            this.colHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBorrowKind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colShop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colShopAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRelet = new System.Windows.Forms.Button();
            this.续租ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.DevicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevicePictureBox)).BeginInit();
            this.UserInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.InfoListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.UserIDLabel.Location = new System.Drawing.Point(233, 26);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(64, 16);
            this.UserIDLabel.TabIndex = 0;
            this.UserIDLabel.Text = "用户ID:";
            this.UserIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.租车还车系统ToolStripMenuItem,
            this.查询系统ToolStripMenuItem,
            this.管理系统ToolStripMenuItem,
            this.充值系统ToolStripMenuItem,
            this.关于ToolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 租车还车系统ToolStripMenuItem
            // 
            this.租车还车系统ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.租车还车系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.租车ToolStripMenuItem,
            this.续租ToolStripMenuItem,
            this.还车ToolStripMenuItem,
            this.挂失ToolStripMenuItem});
            this.租车还车系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.租车还车系统ToolStripMenuItem.Name = "租车还车系统ToolStripMenuItem";
            this.租车还车系统ToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.租车还车系统ToolStripMenuItem.Text = "租车还车系统";
            // 
            // 租车ToolStripMenuItem
            // 
            this.租车ToolStripMenuItem.Name = "租车ToolStripMenuItem";
            this.租车ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.租车ToolStripMenuItem.Text = "租车";
            // 
            // 还车ToolStripMenuItem
            // 
            this.还车ToolStripMenuItem.Name = "还车ToolStripMenuItem";
            this.还车ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.还车ToolStripMenuItem.Text = "还车";
            // 
            // 挂失ToolStripMenuItem
            // 
            this.挂失ToolStripMenuItem.Name = "挂失ToolStripMenuItem";
            this.挂失ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.挂失ToolStripMenuItem.Text = "挂失";
            // 
            // 查询系统ToolStripMenuItem
            // 
            this.查询系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.租还车查询ToolStripMenuItem,
            this.充值查询ToolStripMenuItem,
            this.用户查询ToolStripMenuItem,
            this.日志信息ToolStripMenuItem});
            this.查询系统ToolStripMenuItem.Name = "查询系统ToolStripMenuItem";
            this.查询系统ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.查询系统ToolStripMenuItem.Text = "查询系统";
            // 
            // 租还车查询ToolStripMenuItem
            // 
            this.租还车查询ToolStripMenuItem.Name = "租还车查询ToolStripMenuItem";
            this.租还车查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.租还车查询ToolStripMenuItem.Text = "租还车查询";
            // 
            // 充值查询ToolStripMenuItem
            // 
            this.充值查询ToolStripMenuItem.Name = "充值查询ToolStripMenuItem";
            this.充值查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.充值查询ToolStripMenuItem.Text = "充值查询";
            // 
            // 用户查询ToolStripMenuItem
            // 
            this.用户查询ToolStripMenuItem.Name = "用户查询ToolStripMenuItem";
            this.用户查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.用户查询ToolStripMenuItem.Text = "用户查询";
            // 
            // 日志信息ToolStripMenuItem
            // 
            this.日志信息ToolStripMenuItem.Name = "日志信息ToolStripMenuItem";
            this.日志信息ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.日志信息ToolStripMenuItem.Text = "日志信息";
            this.日志信息ToolStripMenuItem.Click += new System.EventHandler(this.日志信息ToolStripMenuItem_Click);
            // 
            // 管理系统ToolStripMenuItem
            // 
            this.管理系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆信息管理ToolStripMenuItem,
            this.扣费规则管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.管理员信息ToolStripMenuItem,
            this.店铺信息管理ToolStripMenuItem,
            this.审核列表ToolStripMenuItem});
            this.管理系统ToolStripMenuItem.Name = "管理系统ToolStripMenuItem";
            this.管理系统ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.管理系统ToolStripMenuItem.Text = "管理系统";
            // 
            // 车辆信息管理ToolStripMenuItem
            // 
            this.车辆信息管理ToolStripMenuItem.Name = "车辆信息管理ToolStripMenuItem";
            this.车辆信息管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.车辆信息管理ToolStripMenuItem.Text = "车辆信息管理";
            this.车辆信息管理ToolStripMenuItem.Click += new System.EventHandler(this.车辆信息管理ToolStripMenuItem_Click);
            // 
            // 扣费规则管理ToolStripMenuItem
            // 
            this.扣费规则管理ToolStripMenuItem.Name = "扣费规则管理ToolStripMenuItem";
            this.扣费规则管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.扣费规则管理ToolStripMenuItem.Text = "扣费规则管理";
            this.扣费规则管理ToolStripMenuItem.Click += new System.EventHandler(this.扣费规则管理ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 管理员信息ToolStripMenuItem
            // 
            this.管理员信息ToolStripMenuItem.Name = "管理员信息ToolStripMenuItem";
            this.管理员信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.管理员信息ToolStripMenuItem.Text = "管理员信息";
            this.管理员信息ToolStripMenuItem.Click += new System.EventHandler(this.管理员信息ToolStripMenuItem_Click);
            // 
            // 店铺信息管理ToolStripMenuItem
            // 
            this.店铺信息管理ToolStripMenuItem.Name = "店铺信息管理ToolStripMenuItem";
            this.店铺信息管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.店铺信息管理ToolStripMenuItem.Text = "店铺信息管理";
            this.店铺信息管理ToolStripMenuItem.Click += new System.EventHandler(this.店铺信息管理ToolStripMenuItem_Click);
            // 
            // 审核列表ToolStripMenuItem
            // 
            this.审核列表ToolStripMenuItem.Name = "审核列表ToolStripMenuItem";
            this.审核列表ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.审核列表ToolStripMenuItem.Text = "审核列表";
            this.审核列表ToolStripMenuItem.Click += new System.EventHandler(this.审核列表ToolStripMenuItem_Click);
            // 
            // 充值系统ToolStripMenuItem
            // 
            this.充值系统ToolStripMenuItem.Name = "充值系统ToolStripMenuItem";
            this.充值系统ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.充值系统ToolStripMenuItem.Text = "充值系统";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(54, 36);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.退出ToolStripMenuItem.Text = "退出账号";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.00317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.99683F));
            this.tableLayoutPanel1.Controls.Add(this.DevicePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserInfoPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.04293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.95707F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 232);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DevicePanel
            // 
            this.DevicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevicePanel.BackColor = System.Drawing.Color.GhostWhite;
            this.DevicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevicePanel.Controls.Add(this.btnRefreshList);
            this.DevicePanel.Controls.Add(this.btnSelectStore);
            this.DevicePanel.Controls.Add(this.DevicePictureBox);
            this.DevicePanel.Controls.Add(this.storeAddrLabel);
            this.DevicePanel.Controls.Add(this.storeNameLabel);
            this.DevicePanel.Controls.Add(this.DeviceIDLabel);
            this.DevicePanel.Controls.Add(this.LostCarButton);
            this.DevicePanel.Controls.Add(this.returnCarButton);
            this.DevicePanel.Controls.Add(this.btnRelet);
            this.DevicePanel.Controls.Add(this.rentCarButton);
            this.DevicePanel.Location = new System.Drawing.Point(3, 3);
            this.DevicePanel.Name = "DevicePanel";
            this.DevicePanel.Size = new System.Drawing.Size(803, 226);
            this.DevicePanel.TabIndex = 0;
            this.DevicePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSelectStore
            // 
            this.btnSelectStore.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectStore.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSelectStore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelectStore.Location = new System.Drawing.Point(426, 149);
            this.btnSelectStore.Name = "btnSelectStore";
            this.btnSelectStore.Size = new System.Drawing.Size(169, 30);
            this.btnSelectStore.TabIndex = 5;
            this.btnSelectStore.Text = "选择店铺";
            this.btnSelectStore.UseVisualStyleBackColor = false;
            this.btnSelectStore.Click += new System.EventHandler(this.btnSelectStore_Click);
            // 
            // DevicePictureBox
            // 
            this.DevicePictureBox.BackColor = System.Drawing.Color.GhostWhite;
            this.DevicePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevicePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DevicePictureBox.Image")));
            this.DevicePictureBox.Location = new System.Drawing.Point(19, 13);
            this.DevicePictureBox.Name = "DevicePictureBox";
            this.DevicePictureBox.Size = new System.Drawing.Size(200, 200);
            this.DevicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DevicePictureBox.TabIndex = 4;
            this.DevicePictureBox.TabStop = false;
            // 
            // storeAddrLabel
            // 
            this.storeAddrLabel.AutoSize = true;
            this.storeAddrLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.storeAddrLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.storeAddrLabel.Location = new System.Drawing.Point(235, 88);
            this.storeAddrLabel.Name = "storeAddrLabel";
            this.storeAddrLabel.Size = new System.Drawing.Size(80, 16);
            this.storeAddrLabel.TabIndex = 3;
            this.storeAddrLabel.Text = "店铺地址:";
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.storeNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.storeNameLabel.Location = new System.Drawing.Point(235, 57);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(64, 16);
            this.storeNameLabel.TabIndex = 3;
            this.storeNameLabel.Text = "店铺名:";
            // 
            // DeviceIDLabel
            // 
            this.DeviceIDLabel.AutoSize = true;
            this.DeviceIDLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.DeviceIDLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeviceIDLabel.Location = new System.Drawing.Point(235, 26);
            this.DeviceIDLabel.Name = "DeviceIDLabel";
            this.DeviceIDLabel.Size = new System.Drawing.Size(64, 16);
            this.DeviceIDLabel.TabIndex = 3;
            this.DeviceIDLabel.Text = "设备号:";
            // 
            // LostCarButton
            // 
            this.LostCarButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LostCarButton.Font = new System.Drawing.Font("宋体", 12F);
            this.LostCarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LostCarButton.Location = new System.Drawing.Point(238, 179);
            this.LostCarButton.Name = "LostCarButton";
            this.LostCarButton.Size = new System.Drawing.Size(169, 30);
            this.LostCarButton.TabIndex = 2;
            this.LostCarButton.Text = "挂失";
            this.LostCarButton.UseVisualStyleBackColor = false;
            // 
            // returnCarButton
            // 
            this.returnCarButton.BackColor = System.Drawing.Color.SteelBlue;
            this.returnCarButton.Font = new System.Drawing.Font("宋体", 12F);
            this.returnCarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.returnCarButton.Location = new System.Drawing.Point(238, 149);
            this.returnCarButton.Name = "returnCarButton";
            this.returnCarButton.Size = new System.Drawing.Size(169, 30);
            this.returnCarButton.TabIndex = 1;
            this.returnCarButton.Text = "还车";
            this.returnCarButton.UseVisualStyleBackColor = false;
            // 
            // rentCarButton
            // 
            this.rentCarButton.BackColor = System.Drawing.Color.SteelBlue;
            this.rentCarButton.Font = new System.Drawing.Font("宋体", 12F);
            this.rentCarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rentCarButton.Location = new System.Drawing.Point(238, 118);
            this.rentCarButton.Name = "rentCarButton";
            this.rentCarButton.Size = new System.Drawing.Size(169, 30);
            this.rentCarButton.TabIndex = 0;
            this.rentCarButton.Text = "租车";
            this.rentCarButton.UseVisualStyleBackColor = false;
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInfoPanel.Controls.Add(this.UserPicture);
            this.UserInfoPanel.Controls.Add(this.Moneylabel);
            this.UserInfoPanel.Controls.Add(this.UserTypeLabel);
            this.UserInfoPanel.Controls.Add(this.UserNameLabel);
            this.UserInfoPanel.Controls.Add(this.UserIDLabel);
            this.UserInfoPanel.Font = new System.Drawing.Font("宋体", 12F);
            this.UserInfoPanel.Location = new System.Drawing.Point(812, 3);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(449, 226);
            this.UserInfoPanel.TabIndex = 1;
            // 
            // UserPicture
            // 
            this.UserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPicture.Image = global::CarRentalSystem.Properties.Resources.蓝底空白头像;
            this.UserPicture.Location = new System.Drawing.Point(13, 13);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(200, 200);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 1;
            this.UserPicture.TabStop = false;
            // 
            // Moneylabel
            // 
            this.Moneylabel.AutoSize = true;
            this.Moneylabel.Font = new System.Drawing.Font("宋体", 12F);
            this.Moneylabel.Location = new System.Drawing.Point(233, 118);
            this.Moneylabel.Name = "Moneylabel";
            this.Moneylabel.Size = new System.Drawing.Size(48, 16);
            this.Moneylabel.TabIndex = 0;
            this.Moneylabel.Text = "余额:";
            this.Moneylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.UserTypeLabel.Location = new System.Drawing.Point(233, 88);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(80, 16);
            this.UserTypeLabel.TabIndex = 0;
            this.UserTypeLabel.Text = "用户类型:";
            this.UserTypeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.UserNameLabel.Location = new System.Drawing.Point(233, 57);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(64, 16);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "用户名:";
            this.UserNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoListPanel
            // 
            this.InfoListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoListPanel.AutoSize = true;
            this.InfoListPanel.Controls.Add(this.InfoListView);
            this.InfoListPanel.Location = new System.Drawing.Point(3, 278);
            this.InfoListPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.InfoListPanel.Name = "InfoListPanel";
            this.InfoListPanel.Size = new System.Drawing.Size(1258, 394);
            this.InfoListPanel.TabIndex = 2;
            // 
            // InfoListView
            // 
            this.InfoListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeader,
            this.colUserID,
            this.colUserName,
            this.colBorrowKind,
            this.colStartTime,
            this.colPhone,
            this.colCarId,
            this.colShop,
            this.colShopAddress});
            this.InfoListView.Font = new System.Drawing.Font("宋体", 12F);
            this.InfoListView.GridLines = true;
            this.InfoListView.HideSelection = false;
            this.InfoListView.Location = new System.Drawing.Point(0, 0);
            this.InfoListView.Name = "InfoListView";
            this.InfoListView.Size = new System.Drawing.Size(1258, 391);
            this.InfoListView.TabIndex = 1;
            this.InfoListView.UseCompatibleStateImageBehavior = false;
            this.InfoListView.View = System.Windows.Forms.View.Details;
            // 
            // colHeader
            // 
            this.colHeader.Text = "";
            this.colHeader.Width = 0;
            // 
            // colUserID
            // 
            this.colUserID.Text = "用户ID";
            this.colUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUserID.Width = 100;
            // 
            // colUserName
            // 
            this.colUserName.Text = "用户名";
            this.colUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUserName.Width = 100;
            // 
            // colBorrowKind
            // 
            this.colBorrowKind.Text = "租借类型";
            this.colBorrowKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBorrowKind.Width = 100;
            // 
            // colStartTime
            // 
            this.colStartTime.Text = "时间";
            this.colStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStartTime.Width = 100;
            // 
            // colPhone
            // 
            this.colPhone.Text = "电话号码";
            this.colPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhone.Width = 120;
            // 
            // colCarId
            // 
            this.colCarId.Text = "车辆ID";
            this.colCarId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCarId.Width = 100;
            // 
            // colShop
            // 
            this.colShop.Text = "店铺名";
            this.colShop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colShop.Width = 200;
            // 
            // colShopAddress
            // 
            this.colShopAddress.Text = "店铺地址";
            this.colShopAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colShopAddress.Width = 250;
            // 
            // btnRelet
            // 
            this.btnRelet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRelet.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRelet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRelet.Location = new System.Drawing.Point(426, 118);
            this.btnRelet.Name = "btnRelet";
            this.btnRelet.Size = new System.Drawing.Size(169, 30);
            this.btnRelet.TabIndex = 0;
            this.btnRelet.Text = "续租";
            this.btnRelet.UseVisualStyleBackColor = false;
            // 
            // 续租ToolStripMenuItem
            // 
            this.续租ToolStripMenuItem.Name = "续租ToolStripMenuItem";
            this.续租ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.续租ToolStripMenuItem.Text = "续租";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefreshList.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRefreshList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefreshList.Location = new System.Drawing.Point(426, 179);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(169, 30);
            this.btnRefreshList.TabIndex = 5;
            this.btnRefreshList.Text = "刷新列表";
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnSelectStore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.InfoListPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "车辆租赁管理系统";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.DevicePanel.ResumeLayout(false);
            this.DevicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevicePictureBox)).EndInit();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.InfoListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 租车还车系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 充值系统ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel DevicePanel;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 租车ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还车ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂失ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租还车查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 充值查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 扣费规则管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Label Moneylabel;
        private System.Windows.Forms.Panel InfoListPanel;
        private System.Windows.Forms.ListView InfoListView;
        private System.Windows.Forms.ColumnHeader colHeader;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.ColumnHeader colBorrowKind;
        private System.Windows.Forms.ColumnHeader colStartTime;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colShop;
        private System.Windows.Forms.ColumnHeader colCarId;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox DevicePictureBox;
        private System.Windows.Forms.Label storeAddrLabel;
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Label DeviceIDLabel;
        private System.Windows.Forms.Button LostCarButton;
        private System.Windows.Forms.Button returnCarButton;
        private System.Windows.Forms.Button rentCarButton;
        private System.Windows.Forms.ColumnHeader colShopAddress;
        private System.Windows.Forms.ColumnHeader colUserID;
        private System.Windows.Forms.ToolStripMenuItem 管理员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 店铺信息管理ToolStripMenuItem;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.ToolStripMenuItem 审核列表ToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectStore;
        private System.Windows.Forms.ToolStripMenuItem 续租ToolStripMenuItem;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnRelet;
    }
}


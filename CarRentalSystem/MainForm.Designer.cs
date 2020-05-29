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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.租车还车系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.充值系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.租车ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还车ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂失ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租还车查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.充值查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扣费规则管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBorrowKind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBorrowNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.colCarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.还车ToolStripMenuItem,
            this.挂失ToolStripMenuItem});
            this.租车还车系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.租车还车系统ToolStripMenuItem.Name = "租车还车系统ToolStripMenuItem";
            this.租车还车系统ToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.租车还车系统ToolStripMenuItem.Text = "租车还车系统";
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
            // 管理系统ToolStripMenuItem
            // 
            this.管理系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.车辆信息管理ToolStripMenuItem,
            this.扣费规则管理ToolStripMenuItem});
            this.管理系统ToolStripMenuItem.Name = "管理系统ToolStripMenuItem";
            this.管理系统ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.管理系统ToolStripMenuItem.Text = "管理系统";
            // 
            // 充值系统ToolStripMenuItem
            // 
            this.充值系统ToolStripMenuItem.Name = "充值系统ToolStripMenuItem";
            this.充值系统ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.充值系统ToolStripMenuItem.Text = "充值系统";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.00317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.99683F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.04293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.95707F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 629);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 227);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.UserPicture);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(812, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 227);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(233, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 12);
            label1.TabIndex = 0;
            label1.Text = "用户ID：";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户等级：";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(54, 36);
            this.关于ToolStripMenuItem1.Text = "关于";
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
            // 租还车查询ToolStripMenuItem
            // 
            this.租还车查询ToolStripMenuItem.Name = "租还车查询ToolStripMenuItem";
            this.租还车查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.租还车查询ToolStripMenuItem.Text = "租还车查询";
            // 
            // 充值查询ToolStripMenuItem
            // 
            this.充值查询ToolStripMenuItem.Name = "充值查询ToolStripMenuItem";
            this.充值查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.充值查询ToolStripMenuItem.Text = "充值查询";
            // 
            // 日志信息ToolStripMenuItem
            // 
            this.日志信息ToolStripMenuItem.Name = "日志信息ToolStripMenuItem";
            this.日志信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.日志信息ToolStripMenuItem.Text = "日志信息";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 车辆信息管理ToolStripMenuItem
            // 
            this.车辆信息管理ToolStripMenuItem.Name = "车辆信息管理ToolStripMenuItem";
            this.车辆信息管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.车辆信息管理ToolStripMenuItem.Text = "车辆信息管理";
            // 
            // 扣费规则管理ToolStripMenuItem
            // 
            this.扣费规则管理ToolStripMenuItem.Name = "扣费规则管理ToolStripMenuItem";
            this.扣费规则管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.扣费规则管理ToolStripMenuItem.Text = "扣费规则管理";
            // 
            // 用户查询ToolStripMenuItem
            // 
            this.用户查询ToolStripMenuItem.Name = "用户查询ToolStripMenuItem";
            this.用户查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.用户查询ToolStripMenuItem.Text = "用户查询";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.退出ToolStripMenuItem.Text = "退出账号";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "余额：";
            this.label4.Click += new System.EventHandler(this.label1_Click);
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
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 236);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 393);
            this.panel3.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // colUserId
            // 
            this.colUserId.Text = "用户ID";
            this.colUserId.Width = 100;
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
            // colBorrowNum
            // 
            this.colBorrowNum.Text = "租借数量";
            this.colBorrowNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBorrowNum.Width = 80;
            // 
            // colPhone
            // 
            this.colPhone.Text = "电话号码";
            this.colPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhone.Width = 120;
            // 
            // colAddress
            // 
            this.colAddress.Text = "地址";
            this.colAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAddress.Width = 200;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserId,
            this.colUserName,
            this.colBorrowKind,
            this.colStartTime,
            this.colBorrowNum,
            this.colPhone,
            this.colCarId,
            this.colAddress});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("宋体", 12F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1258, 393);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colCarId
            // 
            this.colCarId.Text = "车辆ID";
            this.colCarId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCarId.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录用户：";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "车辆租赁管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 租车还车系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 充值系统ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.ColumnHeader colBorrowKind;
        private System.Windows.Forms.ColumnHeader colStartTime;
        private System.Windows.Forms.ColumnHeader colBorrowNum;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colCarId;
        private System.Windows.Forms.Label label2;
    }
}


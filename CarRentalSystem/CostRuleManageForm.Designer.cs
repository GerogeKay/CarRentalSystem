namespace CarRentalSystem
{
    partial class CostRuleManageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.btnUpdateRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lvRuleList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHourCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDayCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeekCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonthCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeasonCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYearCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 44);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(332, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---收费规则---";
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshList.Location = new System.Drawing.Point(519, 56);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshList.TabIndex = 14;
            this.buttonRefreshList.Text = "刷新";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // btnUpdateRule
            // 
            this.btnUpdateRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateRule.Location = new System.Drawing.Point(681, 56);
            this.btnUpdateRule.Name = "btnUpdateRule";
            this.btnUpdateRule.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateRule.TabIndex = 13;
            this.btnUpdateRule.Text = "修改规则信息";
            this.btnUpdateRule.UseVisualStyleBackColor = true;
            this.btnUpdateRule.Click += new System.EventHandler(this.btnUpdateRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRule.Location = new System.Drawing.Point(600, 56);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(75, 23);
            this.btnAddRule.TabIndex = 12;
            this.btnAddRule.Text = "添加规则";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lvRuleList
            // 
            this.lvRuleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colUserLevel,
            this.colHourCost,
            this.colDayCost,
            this.colWeekCost,
            this.colMonthCost,
            this.colSeasonCost,
            this.colYearCost});
            this.lvRuleList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvRuleList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvRuleList.FullRowSelect = true;
            this.lvRuleList.GridLines = true;
            this.lvRuleList.HideSelection = false;
            this.lvRuleList.Location = new System.Drawing.Point(0, 85);
            this.lvRuleList.Name = "lvRuleList";
            this.lvRuleList.Size = new System.Drawing.Size(784, 365);
            this.lvRuleList.TabIndex = 11;
            this.lvRuleList.UseCompatibleStateImageBehavior = false;
            this.lvRuleList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // colUserLevel
            // 
            this.colUserLevel.Text = "用户等级";
            this.colUserLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUserLevel.Width = 120;
            // 
            // colHourCost
            // 
            this.colHourCost.Text = "时租";
            this.colHourCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHourCost.Width = 110;
            // 
            // colDayCost
            // 
            this.colDayCost.Text = "日租";
            this.colDayCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDayCost.Width = 110;
            // 
            // colWeekCost
            // 
            this.colWeekCost.Text = "周租";
            this.colWeekCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colWeekCost.Width = 110;
            // 
            // colMonthCost
            // 
            this.colMonthCost.Text = "月租";
            this.colMonthCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMonthCost.Width = 110;
            // 
            // colSeasonCost
            // 
            this.colSeasonCost.Text = "季租";
            this.colSeasonCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSeasonCost.Width = 110;
            // 
            // colYearCost
            // 
            this.colYearCost.Text = "年租";
            this.colYearCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colYearCost.Width = 110;
            // 
            // CostRuleManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.btnUpdateRule);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.lvRuleList);
            this.Controls.Add(this.panel1);
            this.Name = "CostRuleManageForm";
            this.Text = "收费规则";
            this.Activated += new System.EventHandler(this.CostRuleManageForm_Activated);
            this.Load += new System.EventHandler(this.CostRuleManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Button btnUpdateRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ListView lvRuleList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colUserLevel;
        private System.Windows.Forms.ColumnHeader colHourCost;
        private System.Windows.Forms.ColumnHeader colDayCost;
        private System.Windows.Forms.ColumnHeader colWeekCost;
        private System.Windows.Forms.ColumnHeader colMonthCost;
        private System.Windows.Forms.ColumnHeader colSeasonCost;
        private System.Windows.Forms.ColumnHeader colYearCost;
    }
}
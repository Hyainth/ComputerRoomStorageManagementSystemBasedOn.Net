namespace Group_08_StorageSystem
{
    partial class StorageMessage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageMessage));
            this.listStorage = new System.Windows.Forms.ListBox();
            this.contextMenuStorage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listStorage
            // 
            this.listStorage.ContextMenuStrip = this.contextMenuStorage;
            this.listStorage.FormattingEnabled = true;
            this.listStorage.ItemHeight = 12;
            this.listStorage.Location = new System.Drawing.Point(12, 26);
            this.listStorage.Name = "listStorage";
            this.listStorage.Size = new System.Drawing.Size(56, 76);
            this.listStorage.TabIndex = 0;
            this.listStorage.SelectedIndexChanged += new System.EventHandler(this.listStorage_SelectedIndexChanged);
            this.listStorage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listStorage_MouseDown);
            // 
            // contextMenuStorage
            // 
            this.contextMenuStorage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.contextMenuStorage.Name = "contextMenuStorage";
            this.contextMenuStorage.Size = new System.Drawing.Size(101, 70);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // listParts
            // 
            this.listParts.FormattingEnabled = true;
            this.listParts.ItemHeight = 12;
            this.listParts.Location = new System.Drawing.Point(12, 140);
            this.listParts.Name = "listParts";
            this.listParts.Size = new System.Drawing.Size(270, 196);
            this.listParts.TabIndex = 1;
            this.listParts.SelectedIndexChanged += new System.EventHandler(this.listParts_SelectedIndexChanged);
            this.listParts.Leave += new System.EventHandler(this.listParts_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "仓库编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "存储列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "label1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(175, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 12);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "label1";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(175, 62);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(41, 12);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "label1";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(175, 96);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(41, 12);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "label1";
            // 
            // buttonIncome
            // 
            this.buttonIncome.Location = new System.Drawing.Point(36, 351);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonIncome.TabIndex = 3;
            this.buttonIncome.Text = "订单查看";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(154, 351);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(75, 23);
            this.buttonTransfer.TabIndex = 3;
            this.buttonTransfer.Text = "物品转移";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // chart1
            // 
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85.9227F;
            chartArea1.InnerPlotPosition.Width = 84.03448F;
            chartArea1.InnerPlotPosition.X = 13.43499F;
            chartArea1.InnerPlotPosition.Y = 2.20974F;
            chartArea1.Name = "ChartArea5";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(288, 41);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea5";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(344, 295);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // StorageMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 386);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listStorage);
            this.Controls.Add(this.listParts);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StorageMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓储管理";
            this.Load += new System.EventHandler(this.StorageMessage_Load);
            this.Click += new System.EventHandler(this.StorageMessage_Click);
            this.contextMenuStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStorage;
        private System.Windows.Forms.ListBox listParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStorage;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
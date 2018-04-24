namespace FrontEnd
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condictionOnRunnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.conditionOnMileTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionOnFinishingPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unifiedProbabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayesWinningFromStall6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.predictionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // predictionsToolStripMenuItem
            // 
            this.predictionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.condictionOnRunnersToolStripMenuItem,
            this.conditionOnMileTimesToolStripMenuItem,
            this.conditionOnFinishingPositionToolStripMenuItem,
            this.unifiedProbabilityToolStripMenuItem,
            this.bayesWinningFromStall6ToolStripMenuItem});
            this.predictionsToolStripMenuItem.Name = "predictionsToolStripMenuItem";
            this.predictionsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.predictionsToolStripMenuItem.Text = "Predictions";
            // 
            // condictionOnRunnersToolStripMenuItem
            // 
            this.condictionOnRunnersToolStripMenuItem.Name = "condictionOnRunnersToolStripMenuItem";
            this.condictionOnRunnersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.condictionOnRunnersToolStripMenuItem.Text = "Condition on Runners";
            this.condictionOnRunnersToolStripMenuItem.Click += new System.EventHandler(this.conditionOnRunnersToolStripMenuItem_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 24);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(284, 237);
            this.chartControl1.TabIndex = 1;
            // 
            // conditionOnMileTimesToolStripMenuItem
            // 
            this.conditionOnMileTimesToolStripMenuItem.Name = "conditionOnMileTimesToolStripMenuItem";
            this.conditionOnMileTimesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.conditionOnMileTimesToolStripMenuItem.Text = "Condition on Mile Times";
            this.conditionOnMileTimesToolStripMenuItem.Click += new System.EventHandler(this.conditionOnMileTimesToolStripMenuItem_Click);
            // 
            // conditionOnFinishingPositionToolStripMenuItem
            // 
            this.conditionOnFinishingPositionToolStripMenuItem.Name = "conditionOnFinishingPositionToolStripMenuItem";
            this.conditionOnFinishingPositionToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.conditionOnFinishingPositionToolStripMenuItem.Text = "Condition on Finishing Position";
            this.conditionOnFinishingPositionToolStripMenuItem.Click += new System.EventHandler(this.conditionOnFinishingPositionToolStripMenuItem_Click);
            // 
            // unifiedProbabilityToolStripMenuItem
            // 
            this.unifiedProbabilityToolStripMenuItem.Name = "unifiedProbabilityToolStripMenuItem";
            this.unifiedProbabilityToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.unifiedProbabilityToolStripMenuItem.Text = "Unified Probability";
            this.unifiedProbabilityToolStripMenuItem.Click += new System.EventHandler(this.unifiedProbabilityToolStripMenuItem_Click);
            // 
            // bayesWinningFromStall6ToolStripMenuItem
            // 
            this.bayesWinningFromStall6ToolStripMenuItem.Name = "bayesWinningFromStall6ToolStripMenuItem";
            this.bayesWinningFromStall6ToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.bayesWinningFromStall6ToolStripMenuItem.Text = "Bayes - Winning from stall 6";
            this.bayesWinningFromStall6ToolStripMenuItem.Click += new System.EventHandler(this.bayesWinningFromStall6ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condictionOnRunnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionOnMileTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionOnFinishingPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unifiedProbabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayesWinningFromStall6ToolStripMenuItem;
    }
}


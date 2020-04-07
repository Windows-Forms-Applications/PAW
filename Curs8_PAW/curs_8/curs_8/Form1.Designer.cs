namespace curs_8
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desenareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dreptunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.umpleDreptunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umpleElipsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umplePlacintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(474, 33);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenareToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desenareToolStripMenuItem
            // 
            this.desenareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dreptunghiToolStripMenuItem,
            this.elipsaToolStripMenuItem,
            this.linieToolStripMenuItem,
            this.placintaToolStripMenuItem});
            this.desenareToolStripMenuItem.Name = "desenareToolStripMenuItem";
            this.desenareToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.desenareToolStripMenuItem.Text = "Desenare";
            // 
            // dreptunghiToolStripMenuItem
            // 
            this.dreptunghiToolStripMenuItem.Name = "dreptunghiToolStripMenuItem";
            this.dreptunghiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dreptunghiToolStripMenuItem.Text = "Dreptunghi";
            this.dreptunghiToolStripMenuItem.Click += new System.EventHandler(this.dreptunghiToolStripMenuItem_Click);
            // 
            // elipsaToolStripMenuItem
            // 
            this.elipsaToolStripMenuItem.Name = "elipsaToolStripMenuItem";
            this.elipsaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.elipsaToolStripMenuItem.Text = "Elipsa";
            this.elipsaToolStripMenuItem.Click += new System.EventHandler(this.elipsaToolStripMenuItem_Click);
            // 
            // linieToolStripMenuItem
            // 
            this.linieToolStripMenuItem.Name = "linieToolStripMenuItem";
            this.linieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linieToolStripMenuItem.Text = "Linie";
            this.linieToolStripMenuItem.Click += new System.EventHandler(this.linieToolStripMenuItem_Click);
            // 
            // placintaToolStripMenuItem
            // 
            this.placintaToolStripMenuItem.Name = "placintaToolStripMenuItem";
            this.placintaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.placintaToolStripMenuItem.Text = "Placinta";
            this.placintaToolStripMenuItem.Click += new System.EventHandler(this.placintaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.umpleDreptunghiToolStripMenuItem,
            this.umpleElipsaToolStripMenuItem,
            this.umplePlacintaToolStripMenuItem,
            this.salvareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 92);
            // 
            // umpleDreptunghiToolStripMenuItem
            // 
            this.umpleDreptunghiToolStripMenuItem.Name = "umpleDreptunghiToolStripMenuItem";
            this.umpleDreptunghiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.umpleDreptunghiToolStripMenuItem.Text = "Umple dreptunghi";
            this.umpleDreptunghiToolStripMenuItem.Click += new System.EventHandler(this.umpleDreptunghiToolStripMenuItem_Click);
            // 
            // umpleElipsaToolStripMenuItem
            // 
            this.umpleElipsaToolStripMenuItem.Name = "umpleElipsaToolStripMenuItem";
            this.umpleElipsaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.umpleElipsaToolStripMenuItem.Text = "Umple elipsa";
            this.umpleElipsaToolStripMenuItem.Click += new System.EventHandler(this.umpleElipsaToolStripMenuItem_Click);
            // 
            // umplePlacintaToolStripMenuItem
            // 
            this.umplePlacintaToolStripMenuItem.Name = "umplePlacintaToolStripMenuItem";
            this.umplePlacintaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.umplePlacintaToolStripMenuItem.Text = "Umple placinta";
            this.umplePlacintaToolStripMenuItem.Click += new System.EventHandler(this.umplePlacintaToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 337);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 361);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desenareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dreptunghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placintaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem umpleDreptunghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umpleElipsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umplePlacintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    }
}


namespace MDI
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
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aranjareFerestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.aranjareFerestreToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.vizualizareToolStripMenuItem});
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.form2ToolStripMenuItem.Text = "Date";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            this.vizualizareToolStripMenuItem.Click += new System.EventHandler(this.vizualizareToolStripMenuItem_Click);
            // 
            // aranjareFerestreToolStripMenuItem
            // 
            this.aranjareFerestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.orizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.aranjareFerestreToolStripMenuItem.Name = "aranjareFerestreToolStripMenuItem";
            this.aranjareFerestreToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.aranjareFerestreToolStripMenuItem.Text = "Aranjare ferestre";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // orizontalToolStripMenuItem
            // 
            this.orizontalToolStripMenuItem.Name = "orizontalToolStripMenuItem";
            this.orizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.orizontalToolStripMenuItem.Text = "Orizontal";
            this.orizontalToolStripMenuItem.Click += new System.EventHandler(this.orizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 337);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aranjareFerestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace curs_8
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            //g = this.CreateGraphics();
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Reprezentare grafica");
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 10;
            chart1.ChartAreas[0].AxisX.Maximum = 6;
            chart1.ChartAreas[0].BackColor = Color.Azure;
            chart1.Series[0].Color = Color.Red;
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.Add(i + 10);
                chart1.Series[0].IsValueShownAsLabel = true;
            }
        }

        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.DrawRectangle(pen, rec);
            g.DrawString("Dreptunghi", this.Font, new SolidBrush(Color.Black),
                new Point(40, 40));
            panel1.Invalidate();
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.DrawEllipse(pen, rec);
            g.DrawString("Elipsa", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold), new SolidBrush(Color.Black),
                new Point(40, 60));
            panel1.Invalidate();
        }

        private void linieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);
            g.DrawLine(pen, new Point(40, 40), new Point(100, 100));
            panel1.Invalidate();
        }

        private void placintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Green, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.DrawPie(pen, rec, 150, 300);
            g.DrawString("Placinta", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold), new SolidBrush(Color.Black),
                new Point(40, 80));
            panel1.Invalidate();
        }

        private void umpleDreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Azure);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.FillRectangle(br, rec);
            panel1.Invalidate();
        }

        private void umpleElipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Yellow);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.FillEllipse(br, rec);
            panel1.Invalidate();
        }

        private void umplePlacintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Pink);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.FillPie(br, rec, 150, 300);
            panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save(this, "desen.bmp");
            save(panel1, "desen.bmp");
            MessageBox.Show("Salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            Rectangle rec = new Rectangle(e.PageBounds.X, e.PageBounds.Y,
                e.PageBounds.Width, e.PageBounds.Height);
            Pen pen = new Pen(Color.Blue, 3);
            gr.DrawRectangle(pen, rec);
            Brush br = new SolidBrush(Color.Red);
            gr.FillEllipse(br, rec);
            gr.DrawString("Paste Fericit! #StamAcasa", new Font(FontFamily.GenericSansSerif, 20),
                new SolidBrush(Color.White), new PointF((e.PageBounds.Width - 200) / 2, e.PageBounds.Height / 2));
        }

        private void pdPrint1(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawString("Paste Fericit! #StamAcasa", new Font(FontFamily.GenericSansSerif, 20),
               new SolidBrush(Color.Black), new Point(e.PageBounds.X, e.PageBounds.Y));
            for (int i = 0; i < 5; i++)
            {
                gr.DrawLine(new Pen(Color.Red, 3), new Point(e.PageBounds.X + (i + 1) * 100 + i * 10, e.PageBounds.Y + 100),
                    new Point(e.PageBounds.X + (i + 1) * 100 + i * 10, e.PageBounds.Y + 100 + (i + 1) * 50));
                gr.DrawString((i + 1).ToString(), this.Font, new SolidBrush(Color.Black),
                    new Point(e.PageBounds.X + (i + 1) * 100 + i * 10, e.PageBounds.Y + 100 + (i + 1) * 50));
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint1);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}

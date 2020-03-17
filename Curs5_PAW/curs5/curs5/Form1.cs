using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace curs5
{
    public partial class Form1 : Form
    {
        bool mouseApasat;
        ArrayList listaPct;
        Graphics context;
        Bitmap img;

        public Form1()
        {
            InitializeComponent();
            listaPct = new ArrayList();
            img = new Bitmap(this.Width, this.Height);
            //context = this.CreateGraphics();
            context = Graphics.FromImage(img);
            hScrollBar1.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                mouseApasat = true;
                label1.Text = "MouseDown";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                Pen creion = new Pen(this.ForeColor);
                creion.Width = hScrollBar1.Value;
                if (mouseApasat == true)
                {
                    context.DrawLine(creion, (Point)listaPct[listaPct.Count - 2], (Point)listaPct[listaPct.Count - 1]);
                    label1.Text = "MouseMove";
                    //Invalidate();
                    panel1.Invalidate();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseApasat = false;
                label1.Text = "MouseUp";
            }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    e.Graphics.DrawImage(img, 0, 0);
        //}

        private void schimbaGrosimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = true;
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.ForeColor = dlg.Color;
        }

        private void save(Control c, string fisier)
        {
            Graphics g = c.CreateGraphics();
            Bitmap bmp = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.Width, c.Height));
            bmp.Save(fisier);
            bmp.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save(this, "poza.bmp");
            save(panel1, "poza.bmp");
            MessageBox.Show("Salvare cu succes!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }




    }
}

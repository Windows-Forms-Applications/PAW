using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            lista.Add(new Abonat(12345, "Ionel Popescu"));
            lista.Add(new Abonat(12112, "Marin Georgescu"));
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(lista);
            frm.MdiParent = this;
            frm.ClientSize = this.ClientSize;
            frm.Show();
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(lista);
            frm.MdiParent = this;
            frm.ClientSize = this.ClientSize;
            frm.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void orizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

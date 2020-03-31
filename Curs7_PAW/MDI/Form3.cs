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
    public partial class Form3 : Form
    {
        ArrayList lista3;

        public Form3(ArrayList lista)
        {
            InitializeComponent();
            lista3 = lista;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Abonat a in lista3)
            {
                ListViewItem itm = new ListViewItem(a.Cnp.ToString());
                itm.SubItems.Add(a.Nume);
                listView1.Items.Add(itm);
            }
        }
    }
}

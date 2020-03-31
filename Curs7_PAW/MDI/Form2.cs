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
    public partial class Form2 : Form
    {
        ArrayList lista2;

        public Form2(ArrayList lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Abonat ab = new Abonat(Convert.ToInt32(tb_cnp.Text), tb_nume.Text);
                lista2.Add(ab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_cnp.Clear();
                tb_nume.Clear();
            }
        }
    }
}

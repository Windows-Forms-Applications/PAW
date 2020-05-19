using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace curs12_paw
{
    public partial class LoginControl : UserControl
    {
        public string connString = null;
        public string tabela = null;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT COUNT(*) FROM "+tabela+" WHERE utilizator='"+tbUser.Text+"' AND parola='"+tbPass.Text+"'";
            try
            {
                conexiune.Open();
                int nr = Convert.ToInt32(comanda.ExecuteScalar());
                if (nr > 0)
                    MessageBox.Show(tbUser.Text + " s-a autentificat!");
                else
                    MessageBox.Show("Utilizatorul nu exista!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}

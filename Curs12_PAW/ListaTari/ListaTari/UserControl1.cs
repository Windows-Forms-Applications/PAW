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

namespace ListaTari
{
    public partial class UserControl1: UserControl
    {
        public string tabela = null;

        public UserControl1()
        {
            InitializeComponent();

            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("Denumire");
            //dt.Rows.Add("1", "Albania");
            //dt.Rows.Add("2", "Argentina");
            //dt.Rows.Add("3", "Bulgaria");
            //dt.Rows.Add("4", "Canada");

            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "Denumire";
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = login.accdb");
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT * FROM " + tabela;
            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Denumire"]);
                }
                reader.Close();
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

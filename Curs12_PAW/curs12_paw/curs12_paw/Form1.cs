using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs12_paw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loginControl1.connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = login.accdb";
            loginControl1.tabela = "useri";

            userControl11.tabela = "tari";
        }
    }
}

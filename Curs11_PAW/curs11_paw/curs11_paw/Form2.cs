using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs11_paw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.studenti' table. You can move, or remove it, as needed.
            this.studentiTableAdapter.Fill(this.studentDataSet.studenti);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Observatii");
            listView1.Items[0].BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Student[] vs = new Student[3];
            List<Student> ls = new List<Student>();
            //vs[0] = new Student(100, "Ionescu", 9);
            //vs[1] = new Student(200, "Popescu", 8);
            //vs[2] = new Student(300, "Georgescu", 7);
            ls.Add(new Student(100, "Ionescu", 9));
            ls.Add(new Student(200, "Popescu", 8));
            ls.Add(new Student(300, "Georgescu", 7));
            //foreach (Student s in vs)
            foreach (Student s in ls)
            {
                ListViewItem item = new ListViewItem(s.Cod.ToString());
                item.SubItems.Add(s.Nume);
                item.SubItems.Add(s.Nota.ToString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected == true) itm.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student(Convert.ToInt32(tb_cod.Text), 
                    tb_nume.Text, (float)Convert.ToDouble(tb_nota.Text));
                ListViewItem item = new ListViewItem(s.Cod.ToString());
                item.SubItems.Add(s.Nume);
                item.SubItems.Add(s.Nota.ToString());
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare introducere date!");
            }
            finally
            {
                tb_cod.Clear();
                tb_nume.Clear();
                tb_nota.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked == true) itm.Remove();
            listView1.Sorting = SortOrder.Ascending;
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked==true) 
                e.Item.BackColor = Color.Gray;
        }
    }
}

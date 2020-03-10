using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                //fs.Close();
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(textBox1.Text);
                textBox1.Clear();
                sw.Close();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                textBox1.Font = dlg.Font;
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = dlg.Color;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            //ArrayList lista = new ArrayList();
            //foreach (string linie in textBox1.Lines)
            //    lista.Add(linie);
            //bf.Serialize(fs, lista);
            //bf.Serialize(fs, textBox1.Text);
            Student s = new Student(21, "Gigel", 9.9f);
            bf.Serialize(fs, s);
            textBox1.Clear();
            fs.Close();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            //textBox1.Text = (string)bf.Deserialize(fs);
            //ArrayList lista2 = (ArrayList)bf.Deserialize(fs);
            //for (int i = 0; i < lista2.Count; i++)
            //    textBox1.Text += lista2[i] + Environment.NewLine;
            Student s2 = (Student)bf.Deserialize(fs);
            textBox1.Text = s2.ToString();
            fs.Close();
        }
    }
}

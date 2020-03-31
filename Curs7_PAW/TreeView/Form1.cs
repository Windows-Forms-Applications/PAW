using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;

namespace TreeView
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            InitializareLista();
            InitializareTreeView();
        }

        public void InitializareLista()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    int cod = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    float nota = (float)Convert.ToDouble(linie.Split(',')[2]);
                    Student s = new Student(cod, nume, nota);
                    lista.Add(s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
        }

        public void InitializareTreeView()
        {
            TreeNode parinte = new TreeNode("Studenti");
            treeView1.Nodes.Add(parinte);

            foreach (Student s in lista)
            {
                TreeNode copil = new TreeNode(s.Cod + "-" + s.Nume + "-" + s.Nota);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (s.Nota > 8)
                    nepot.Text = "Excelent";
                else 
                    nepot.Text = "Bunicel";
                copil.Nodes.Add(nepot);
            }
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                TreeNode nodSelectat = treeView1.SelectedNode;
                if (nodSelectat.Parent != null)
                {
                    int cod;
                    try
                    {
                        cod = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);
                    }
                    catch (Exception)
                    {
                        cod = 0;
                    }
                    foreach (Student s in lista)
                        if (s.Cod == cod)
                            textBox1.Text += s.ToString() + Environment.NewLine;
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                TreeNode nodSelectat = treeView1.SelectedNode;
                if (nodSelectat.NextNode != null)
                    nodSelectat = treeView1.SelectedNode.NextNode;
                else
                    if (nodSelectat.PrevNode != null)
                        nodSelectat = treeView1.SelectedNode.PrevNode;
                treeView1.SelectedNode.Remove();
                treeView1.SelectedNode = nodSelectat;
            }
        }

        private void reincarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializareTreeView();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            using (writer)
            {
                writer.WriteStartDocument();
               
                foreach(TreeNode nod in treeView1.Nodes)
                {
                    writer.WriteStartElement(nod.Text);
                    foreach (TreeNode copil in nod.Nodes)
                    {
                        writer.WriteStartElement(copil.Text.Split('-')[0] + "_" + copil.Text.Split('-')[1]);
                        //writer.WriteValue(copil.Text.Split('-')[2]);
                        writer.WriteValue(copil.Nodes[0].Text);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
               
                writer.WriteEndDocument();
            }
            writer.Close();
            string xml = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();
            StreamWriter sw = new StreamWriter("fisie.xml");
            sw.WriteLine(xml);
            sw.Close();
            MessageBox.Show("Export cu succes!");
        }
    }
}

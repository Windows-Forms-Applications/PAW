using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs6_paw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = toolStripTbNume.Text;
                int nota = Convert.ToInt32(toolStripTbNota.Text);
                string sex = toolStripCbSex.Text;
                string cnp = toolStripTbCnp.Text;
                Student s = new Student(nume, cnp, sex, nota);
                MessageBox.Show(s.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = dlg.Color;
        }

        private void schumbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.Font = dlg.Font;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbCnp.Text == "")
                    errorProvider1.SetError(tbCnp, "Introduceti CNP!");
                else
                    if (cbSex.Text == "")
                        errorProvider1.SetError(cbSex, "Selectati sexul!");
                    else
                        if (tbNota.Text == "")
                            errorProvider1.SetError(tbNota, "Introduceti nota!");
                        else
                            if (tbCnp.Text.Substring(0, 1) == "1" && cbSex.Text == "Feminin")
                            {
                                errorProvider1.SetError(tbCnp, "CNP nu corespunde cu sex!");
                                errorProvider1.SetError(cbSex, "Sex nu corespunde cu CNP!");
                            }
                            else
                                if (tbCnp.Text.Substring(0, 1) == "2" && cbSex.Text == "Masculin")
                                {
                                    errorProvider1.SetError(tbCnp, "CNP nu corespunde cu sex!");
                                    errorProvider1.SetError(cbSex, "Sex nu corespunde cu CNP!");
                                }
                                else
                                {
                                    try
                                    {
                                        string nume = tbNume.Text;
                                        int nota = Convert.ToInt32(tbNota.Text);
                                        string sex = cbSex.Text;
                                        string cnp = tbCnp.Text;
                                        Student s = new Student(nume, cnp, sex, nota);
                                        MessageBox.Show(s.ToString());
                                        toolStripProgressBar1.MarqueeAnimationSpeed = 10;
                                        toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
                                        toolStripProgressBar1.Value += 10;
                                        toolStripStatusLabel1.Text = System.DateTime.Now.ToString();

                                        throw new ExceptiaMea("Exceptie personalizata!");
                                    }
                                    catch (ExceptiaMea ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    finally
                                    {
                                        errorProvider1.Clear();
                                    }
                                }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString();
        }

        private void tbNota_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int nota = Convert.ToInt32(tbNota.Text);
                if (nota < 1 || nota > 10)
                    MessageBox.Show("Nota trebuie intre 1-10!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNota_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Am validat!");
        }

        private void tbCnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //    e.Handled = true;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }

    public class ExceptiaMea : ApplicationException
    {
        public ExceptiaMea()
            : base()
        {
        }

        public ExceptiaMea(string mesaj)
            : base(mesaj)
        {
        }
    }
}

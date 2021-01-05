using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Gère_le_système_d_information_d_une_société
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("donner le metricule");
                textBox1.Focus();
            }else if(textBox2.Text=="")
            {
                MessageBox.Show("donner le nom et le prenom");
                textBox2.Focus();
            }else if(textBox3.Text=="")
            {
                MessageBox.Show("donner l'email");
                textBox3.Focus();
            }
            else if(textBox5.Text=="")
            {
                MessageBox.Show("donner le nombre des heurs");
                textBox5.Focus();
            }
            else
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("donner le type de développeur ");
                    groupBox1.Focus();
                }
                else if (radioButton1.Checked)
                {
                    textBox4.Enabled = true;
                    if(textBox4.Text=="")
                    {
                        MessageBox.Show("donner le taux horaire");
                        textBox4.Focus();
                    }
                    else
                    {
                        Externe E = new Externe(textBox1.Text, textBox2.Text, textBox3.Text, double.Parse(textBox4.Text), int.Parse(textBox5.Text));
                        list_developpeurs.list_dev.Add(E);
                        MessageBox.Show("developpeur Extern enrgistrer");
                    }
                }
                else if(radioButton2.Checked)
                {
                    if (!radioButton3.Checked && !radioButton4.Checked)
                    {
                        MessageBox.Show("donner le type de développeur interne");
                        groupBox2.Focus();
                    }
                    else
                    {
                        if(radioButton4.Checked)
                        {
                            Interne I1 = new Interne(textBox1.Text, textBox2.Text, textBox3.Text, radioButton3.Text, int.Parse(textBox5.Text));
                            list_developpeurs.list_dev.Add(I1);
                            MessageBox.Show("developpeur Interne ==> Junior enrgistrer");
                        }
                        else if(radioButton3.Checked)
                        {
                            Interne I2 = new Interne(textBox1.Text, textBox2.Text, textBox3.Text, radioButton4.Text, int.Parse(textBox5.Text));
                            list_developpeurs.list_dev.Add(I2);
                            MessageBox.Show("developpeur Interne ==> Senior enrgistrer");
                        }
                    }
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false; 
            textBox4.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            textBox4.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}

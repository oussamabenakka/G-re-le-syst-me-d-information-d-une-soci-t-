using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gère_le_système_d_information_d_une_société
{
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<Developpeurs> list_supprimer = new List<Developpeurs>();
        private void Supprimer_Load(object sender, EventArgs e)
        {
            foreach(Developpeurs dev in list_developpeurs.list_dev)
            {
                listBox1.Items.Add(dev.Matricule + "  " + dev.Nom_prenom);
            }
            foreach (Projet p in list_developpeurs.lis_projet)
            {
                foreach(Developpeurs dev in p.List)
                listBox2.Items.Add(dev.Matricule + "  " + dev.Nom_prenom);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Developpeurs dev in list_developpeurs.list_dev)
            {
                if (listBox1.SelectedItem.ToString() == (dev.Matricule + "  " + dev.Nom_prenom))
                {
                    list_developpeurs.list_dev.Remove(dev);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    MessageBox.Show("Supprimer");
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Projet p in list_developpeurs.lis_projet)
            {
                foreach(Developpeurs dev in p.List)
                {
                    if (listBox2.SelectedItem.ToString() == (dev.Matricule + "  " + dev.Nom_prenom))
                    {
                        p.List.Remove(dev);
                        listBox2.Items.Remove(listBox2.SelectedItem);
                        MessageBox.Show("Supprimer");
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Projet Pr = (Projet)list_developpeurs.lis_projet[comboBox1.SelectedIndex];
            foreach (Developpeurs dev in Pr.List)
            {
                if (dev is Externe)
                    listBox1.Items.Add(dev.Matricule+"  "+dev.Nom_prenom);
                else if (dev is Interne)
                    listBox2.Items.Add(dev.Matricule+"  "+dev.Nom_prenom);
            }
        }
    }
}

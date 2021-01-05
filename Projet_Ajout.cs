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
    public partial class Projet_Ajout : Form
    {
        public Projet_Ajout()
        {
            InitializeComponent();
        }

        private void Projet_Ajout_Load(object sender, EventArgs e)
        {
            foreach(Developpeurs dev in list_developpeurs.list_dev)
            {
                listBox1.Items.Add(dev.Matricule+" "+ dev.Nom_prenom);
            }
            list_developpeurs.lis_projet.Add(new Projet("ARBDY6", "Gestion des Marchandises"));
            list_developpeurs.lis_projet.Add(new Projet("JKEHD3", "Gestion des Cargaison"));
            list_developpeurs.lis_projet.Add(new Projet("EDFSEDF", "Gestion des Stagaires"));
            foreach(Projet Pr in list_developpeurs.lis_projet)
            {
                comboBox1.Items.Add(Pr.Nom);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Projet Pr in list_developpeurs.lis_projet)
            {
                if(comboBox1.SelectedItem.ToString()==Pr.Nom)
                {
                   foreach(Developpeurs dev in list_dev_selectioner)
                    {
                        Pr.AjoutParticipant(dev);
                    }
                    list_dev_selectioner.Clear();
                    listBox2.Items.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Developpeurs> list_dev_selectioner = new List<Developpeurs>();
        private void button3_Click(object sender, EventArgs e)
        {
            Developpeurs dev = (Developpeurs)list_developpeurs.list_dev[listBox1.SelectedIndex];
            list_dev_selectioner.Add(dev);
            listBox2.Items.Add(dev.Matricule + "  " + dev.Nom_prenom);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

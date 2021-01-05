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
    public partial class Afficher_Projet : Form
    {
        public Afficher_Projet()
        {
            InitializeComponent();
        }
        private void Afficher_Projet_Load(object sender, EventArgs e)
        {
            foreach(Projet Pr in list_developpeurs.lis_projet)
            {
                comboBox1.Items.Add(Pr.Nom);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Projet Pr = (Projet)list_developpeurs.lis_projet[comboBox1.SelectedIndex];
            foreach (Developpeurs dev in Pr.List)
            {
                if (dev is Externe)
                    dataGridView1.Rows.Add(dev.Matricule, dev.Nom_prenom, "Externe", dev.CalculeSalaire());
                else if (dev is Interne)
                    dataGridView1.Rows.Add(dev.Matricule, dev.Nom_prenom, "Interne", dev.CalculeSalaire());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

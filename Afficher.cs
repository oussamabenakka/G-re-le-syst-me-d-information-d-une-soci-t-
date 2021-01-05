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
    public partial class Afficher : Form
    {
        public Afficher()
        {
            InitializeComponent();
        }
        private void Afficher_Load(object sender, EventArgs e)
        {
             foreach(Developpeurs dev in list_developpeurs.list_dev)
            {
                if(dev is Externe)
                {
                    dataGridView1.Rows.Add(dev.Matricule, dev.Nom_prenom, dev.Email, "Externe", "",dev.CalculeSalaire());
                }
                else if(dev is Interne)
                {
                    dataGridView1.Rows.Add(dev.Matricule, dev.Nom_prenom, dev.Email, "Interne", "",dev.CalculeSalaire());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

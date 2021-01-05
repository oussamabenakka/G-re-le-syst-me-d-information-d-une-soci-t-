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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Ajouter";
            SlidPanel.Height = button2.Height;
            SlidPanel.Top = button2.Top;
            SlidPanel.Visible = true;
            Ajouter Aj = new Ajouter();
            Aj.Show(); button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Afficher";
            SlidPanel.Height = button3.Height;
            SlidPanel.Top = button3.Top;
            SlidPanel.Visible = true;
            Afficher af = new Afficher(); button6.Enabled = true;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = " Ajouter aux Projet";
            SlidPanel.Height = button5.Height;
            SlidPanel.Top = button5.Top;
            SlidPanel.Visible = true;
            Projet_Ajout Pa = new Projet_Ajout(); button6.Enabled = true;
            Pa.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Sauvgarder";
            SlidPanel.Height = button6.Height;
            SlidPanel.Top = button6.Top;
            SlidPanel.Visible = true;
            FileStream F = new FileStream("Developpeurs.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(F,list_developpeurs.list_dev);
            F.Close();
            MessageBox.Show("Sauvgarder");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "bienvenue";
            button6.Enabled = false;
            SlidPanel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Restaurer";
            SlidPanel.Height = button7.Height;
            SlidPanel.Top = button7.Top;
            SlidPanel.Visible = true;
            button6.Enabled = true;
            FileStream F = new FileStream("Developpeurs.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            list_developpeurs.list_dev = (List<Developpeurs>)bf.Deserialize(F);
            F.Close();
            MessageBox.Show("Restaurer");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Afficher  Projet";
            SlidPanel.Height = button4.Height;
            SlidPanel.Top = button4.Top;
            SlidPanel.Visible = true;
            button6.Enabled = true;
            Afficher_Projet Af = new Afficher_Projet();
            Af.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Supprimer";
            SlidPanel.Height = button8.Height;
            SlidPanel.Top = button8.Top;
            SlidPanel.Visible = true;
            button6.Enabled = true;
            Supprimer s = new Supprimer();
            s.Show();
        }
    }
}

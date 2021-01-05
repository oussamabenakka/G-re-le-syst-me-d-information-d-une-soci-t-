using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Gère_le_système_d_information_d_une_société
{
    [Serializable]
    class Interne:Developpeurs
    {
        private int nbr_h;
        private string categorie;
        public string Categorie
        {
            get { return this.categorie; }
            set { this.categorie = value; }
        }
        public int Nbr_h
        {
            get { return this.nbr_h; }
            set { this.nbr_h = value; }
        }
        public Interne()
        { }
        public Interne(string matricule, string nom_prenom, string email,string categorie,int nbr_h) : base(matricule, nom_prenom, email)
        {
            this.categorie = categorie;
            this.nbr_h = nbr_h;
        }
        public override double CalculeSalaire()
        {
            if (this.categorie == "Sénior")
                return (5000 + this.nbr_h * 150);
            else if (this.categorie == "Junior")
                return (8000 + this.nbr_h * 200);
            else return 0;
        }
    }
}

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
    class Developpeurs
    {
        private string matricule;
        private string nom_prenom;
        private string email;
        private double salaire;
        public string Matricule
        {
            get { return this.matricule; }
            set { this.matricule = value; }
        }
        public string Nom_prenom
        {
            get { return this.nom_prenom; }
            set { this.nom_prenom = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public double Salaire
        {
            get { return this.salaire; }
            set { this.salaire = value; }
        }
        public Developpeurs()
        { }
        public Developpeurs(string matricule, string nom_prenom,string email,double salaire)
        {
            this.matricule = matricule;
            this.nom_prenom = nom_prenom;
            this.email = email;
            this.salaire = salaire;
        }
        public virtual double CalculeSalaire()
        {
            return 0;
        }
    }
}

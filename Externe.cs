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
    class Externe:Developpeurs
    {
        private int nbr_h;
        private double taux_h;

        public double Taux_h
        {
            get { return this.taux_h; }
            set { this.taux_h = value; }
        }
        public int Nbr_h
        {
            get { return this.nbr_h; }
            set { this.nbr_h = value; }
        }
        public Externe()
        { }
        public Externe(string matricule, string nom_prenom, string email, double taux_h, int nbr_h) : base(matricule, nom_prenom, email)
        {
            this.taux_h = taux_h;
            this.nbr_h = nbr_h;
        }
        public override double CalculeSalaire()
        {
            return this.nbr_h*this.taux_h;
        }
    }
}

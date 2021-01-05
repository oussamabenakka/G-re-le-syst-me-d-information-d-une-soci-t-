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
    class Projet
    {
        private string identification;
        private string nom;
        private List<Developpeurs> list = new List<Developpeurs>();
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public List<Developpeurs> List
        {
            get { return this.list; }
            set { this.list = value; }
        }
        public Projet()
        { }
        public Projet(string identification,string nom)
        {
            this.identification = identification;
            this.nom = nom;
        }
        public void AjoutParticipant(Developpeurs dev)
        {
            list.Add(dev);
        }
        public double CalculsalaireTotal()
        {
            double Total = 0;
            foreach(Developpeurs dev in list)
            {
                Total += dev.CalculeSalaire();
            }
            return Total;
        }
    }
}

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
    class list_developpeurs
    {
        public static List<Developpeurs> list_dev = new List<Developpeurs>();
        public static List<Projet> lis_projet = new List<Projet>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ECF4dao
{
    public class ContratDAO
    {
        // Déclarations de valeurs 

        private static List<Client> Clients;
        private static List<Contrat> Contrats;
        private static List<CentreInformatique> Centres;

        // Init
        public static void init()
        {
            // Clients
            Client cl1 = new Client(1, "Panzani", "34, avenue de corot", 13013, "Marseille", "0491609023");
            Client cl2 = new Client(2, "Heineken", "14, rue François Chardigny", 13011, "Marseille", "0491691322");
            Clients = new List<Client>();
            Clients.Add(cl1);
            Clients.Add(cl2);

            //Centres
            CentreInformatique ceinfo1 = new CentreInformatique(1, "34, avenue de corot", 13013, "Marseille", "0491609023",
                cl1);
            CentreInformatique ceinfo2 = new CentreInformatique(2, "11, chemin du littoral", 13015, "Marseille", "0491601462",
                cl1);
            Centres = new List<CentreInformatique>();
            Centres.Add(ceinfo1);
            Centres.Add(ceinfo2);

            //Contrats
            Contrat ct1 = new Contrat(1, 24.65, new DateTime(2011,02,12), 1, cl1, ceinfo1);
            Contrat ct2 = new Contrat(2, 13.480, new DateTime(2011,03,13), 1, cl1, ceinfo2);
            Contrats = new List<Contrat>();
            Contrats.Add(ct1);            
            Contrats.Add(ct2);
        }

        // Methodes
        #region 
        public static List<Client> GetAllClients()
        {
            return Clients;
        }

        public static List<Contrat> GetContratByCentre(int ct)
        {
            var Cti = Contrats.Where(p => p.Centre.num_centre == ct).ToList();
            return Cti;
        }

        public static List<CentreInformatique> GetAllCentresByClient(int cl)
        {
            var Cc = Centres.Where(p => p.Client.num_client == cl).ToList();
            return Cc;
        }

        public static bool ResContrat(Contrat crt)
        {
            int rang = Contrats.IndexOf(crt);
            if (rang != -1)
            {
                Contrats[rang] = crt;
                return true;
            }
            else return false;
        }
        #endregion
    }
}

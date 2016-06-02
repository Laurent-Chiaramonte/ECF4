﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ECF4dao
{
    public class ContratDAO
    {
        private static List<Client> Clients;
        private static List<Contrat> Contrats;
        private static List<CentreInformatique> Centres;

        public static void init()
        {
            Client cl1 = new Client(1, "Panzani", "34, avenue de corot", 13013, "Marseille", "0491609023");
            Client cl2 = new Client(2, "Heineken", "14, rue François Chardigny", 13011, "Marseille", "0491691322");
            Clients = new List<Client>();
            Clients.Add(cl1);
            Clients.Add(cl2);

            Contrat ct1 = new Contrat(1, 24.65, new DateTime(12 / 02 / 2011), 1, cl1);
            Contrat ct2 = new Contrat(2, 13.480, new DateTime(13 / 03 / 2011), 1, cl1);
            Contrats = new List<Contrat>();
            Contrats.Add(ct1);
            Contrats.Add(ct2);

            CentreInformatique ceinfo1 = new CentreInformatique(1, "34, avenue de corot", 13013, "Marseille", "0491609023",
                ct1, cl1);
            CentreInformatique ceinfo2 = new CentreInformatique(2, "11, chemin du littoral", 13015, "Marseille", "0491601462",
                ct2, cl1);
            Centres = new List<CentreInformatique>();
            Centres.Add(ceinfo1);
            Centres.Add(ceinfo2);

         


        }

        // Methodes

        public static List<Client> GetAllClients()
        {
            return Clients;
        }

        public static List<Contrat> GetAllContrats()
        {
            return Contrats;
        }

        public static List<CentreInformatique> GetAllCentres()
        {
            return Centres;
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
    }
}
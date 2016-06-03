using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF4Console
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Init
            ECF4dao.ContratDAO.init();
            List<Client> lstcl = ECF4dao.ContratDAO.GetAllClients();

            Console.WriteLine("Gérer contrat : ");

            // Liste Clients
            Console.WriteLine("Liste des clients : ");

            foreach (Client cl in lstcl)
            {
                Console.WriteLine(cl);
            }

            // Liste Centres par Clients
            Console.WriteLine("Quel client voulez-vous afficher?");

            int idcli = Convert.ToInt16(Console.ReadLine());

            List<CentreInformatique> lstctinfo = ECF4dao.ContratDAO.GetAllCentresByClient(idcli);

            foreach (CentreInformatique ci in lstctinfo)
            {
                Console.WriteLine(ci);
            }

            // Afficher Contrat par Centre
            Console.WriteLine("Quel centre voulez-vous afficher?");

            int idctinfo = Convert.ToInt16(Console.ReadLine());
            int idct = 0;
            List<Contrat> lstcont = ECF4dao.ContratDAO.GetContratByCentre(idctinfo);
            Contrat crt = null;
           
            foreach (Contrat ct in lstcont)
            {
                Console.WriteLine(ct);
                idct = ct.num_contrat;
                crt = ct;
            }

            // Résiliation du contrat
            Console.WriteLine("Voulez-vous résilier le contrat? y/n ");
            string rep = Console.ReadLine();
            while (rep != "y" && rep != "n")
            {
                Console.WriteLine("Veuillez répondre par y ou n !");
                rep = Console.ReadLine();
            }
            if (rep == "y")
            {
                
                // resiliation
                Contrat resct = new Contrat(crt.num_contrat, crt.montant_contrat, crt.date_validite_contrat,
                    3, crt.Client, crt.Centre, "Résilié par le client");
                if (ECF4dao.ContratDAO.ResContrat(resct))
                {
                    Console.WriteLine("Le contrat a été résilié !");
                    Console.WriteLine(resct);
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite");
                }
                
            }
            else if (rep == "n")
            {
                Console.WriteLine("Fin du programme");
            }
        

            Console.ReadLine();
        }
    }
}

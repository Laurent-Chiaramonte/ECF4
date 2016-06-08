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
            Contrat crt = null;

            // Init
            #region
            ECF4dao.ContratDAO.init();

            List<Client> lstcl = ECF4dao.ContratDAO.GetAllClients();

            Console.WriteLine("Gérer contrat : ");
            #endregion

            // Liste Clients
            #region
            Console.WriteLine("\nListe des clients : ");

            foreach (Client cl in lstcl)
            {
                Console.WriteLine(cl);
            }
            #endregion

            // Liste Centres par Clients
            #region
            
            bool bError;

            do
            {
                try
                {
                    bError = false;

                    Console.WriteLine("Quel client voulez-vous afficher?");

                    string idclient = Console.ReadLine();

                    int idcli = 0;

                    idcli = int.Parse(idclient);

                    List<CentreInformatique> lstctinfo = ECF4dao.ContratDAO.GetAllCentresByClient(idcli);

                    if (lstctinfo.Count == 0)
                    {
                        bError = true;
                        Console.WriteLine("Le client selectionné n'a pas de centre ou n'existe pas !");
                    }
                    else
                    {
                        bError = false;
                        foreach (CentreInformatique ci in lstctinfo)
                        {
                            Console.WriteLine(ci);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur dans la saisie !");
                    bError = true;
                }
            } while (bError);


            #endregion

            // Afficher Contrat par Centre
            #region

            do
            {
                try
                {
                    bError = false;
                    
                    Console.WriteLine("\nQuel centre voulez-vous afficher?");

                    string idcentreinfo = Console.ReadLine();

                    int idctinfo = 0;

                    idctinfo = int.Parse(idcentreinfo);

                    int idct = 0;

                    List<Contrat> lstcont = ECF4dao.ContratDAO.GetContratByCentre(idctinfo);

                    if (lstcont.Count == 0)
                    {
                        bError = true;
                        Console.WriteLine("Le centre n'existe pas !");
                    }
                    else
                    {
                        bError = false;
                        foreach (Contrat ct in lstcont)
                        {
                            Console.WriteLine(ct);
                            idct = ct.num_contrat;
                            crt = ct;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur dans la saisie !");
                    bError = true;
                }
            } while (bError);
            #endregion

            // Résiliation du contrat
            #region
            Console.WriteLine("\nVoulez-vous résilier le contrat? y/n ");

            string rep = Console.ReadLine();

            while (rep != "y" && rep != "n")
            {
                Console.WriteLine("Veuillez répondre par y ou n !");
                rep = Console.ReadLine();
            }
            if (rep == "y")
            {
                Contrat resct = new Contrat(crt.num_contrat, crt.montant_contrat, crt.date_validite_contrat,
                    3, crt.Client, crt.Centre, "Résilié par le client");
                if (ECF4dao.ContratDAO.ResContrat(resct))
                {
                    Console.WriteLine("\nLe contrat a été résilié !");
                    Console.WriteLine(resct);
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite");
                }
                
            }
            else if (rep == "n")
            {
                Console.WriteLine("\n Fin du programme");
            }
            #endregion


            Console.ReadLine();
        }
    }
}

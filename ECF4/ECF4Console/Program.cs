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
            ECF4dao.ContratDAO.init();
            List<Client> lstcl = ECF4dao.ContratDAO.GetAllClients();

            Console.WriteLine("Afficher clients : ");

            foreach (Client cl in lstcl)
            {
                Console.WriteLine(cl);
            }


            Console.ReadLine();
        }
    }
}

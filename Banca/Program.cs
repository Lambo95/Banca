using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Esegui();
        }

        private static void Esegui()
        {
            bool schermo = true;
            Conto conto = CreaConto();
            while (schermo)
            {
                schermo = SchermoMenuConto(conto);
                
            }
        }

        public static Conto CreaConto()
        {
            Console.WriteLine("Per creare il conto, seguire i seguenti passaggi");
            Console.WriteLine("Digita il tuo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digita il tuo cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Devi fare un versamento di almeno 1000€ per aprire il conto..");
            double versamento = double.Parse(Console.ReadLine());
            Conto conto = new Conto(nome, cognome, versamento);
            if (versamento >= 1000)
            {
                Console.WriteLine($"Conto creato con successo! \n {conto.ToString()}");
            }
            else
            {
                Console.WriteLine("Devi fare un versamento di almeno 1000€ per aprire il conto..\n Riaccedi per rinizaire!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return conto;

        }

        public static double PrelievoDalConto()
        {
            Console.WriteLine("Quanto vuoi prelevere?");
            double prelievo = double.Parse(Console.ReadLine());
            return prelievo;
        }

        public static double VersamentoDalConto()
        {
            Console.WriteLine("Quanto vuoi versare?");
            double versamento = double.Parse(Console.ReadLine());
            return versamento;
        }

        public static bool SchermoMenu()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("************** BANCA DI TOPOLINO  *****************");
            Console.WriteLine("----------------------- V.1 ---------------------------");
            Console.WriteLine("\n \t \t ************** MENU ****************");
            Console.WriteLine("0 - per uscire");
            Console.WriteLine("1 - Crea nuovo contocorrente");


            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                   Esegui();
                    return false;
                default:
                    return true;
            }
        }

        public static bool SchermoMenuConto(Conto conto)
        {
            
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("************** BANCA DI TOPOLINO  *****************");
                Console.WriteLine("----------------------- V.1 ---------------------------");
                Console.WriteLine("\n \t \t ************** MENU ****************");
                Console.WriteLine("0 - per uscire");
                Console.WriteLine("1 - Fai un prelievo");
                Console.WriteLine("2 - Fai un versamento");
                Console.WriteLine("3 - Stampa saldo");
                Console.WriteLine("4 - Crea nuovo conto");
             

            switch (Console.ReadLine())
            {
                case "0":
                    Environment.Exit(0);
                   return false;
                case "1":
                    conto.Prelievo(PrelievoDalConto());
                    return true;
                case "2":
                    conto.Versamento(VersamentoDalConto());
                    return true;
                case "3":
                    Console.WriteLine(conto.ToString());
                    return true;
                case "4":
                    SchermoMenu();
                    return true;
                default:
                    Console.WriteLine("Digita un numero tra 0 e 4 ");
                    return true;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    public struct Distributeur
    {
        public Dictionary<string, int> stocks;

        public bool BoissonDisponible(string nom, out int quantite)
        {
            quantite = 0;
            if (stocks.ContainsKey(nom))
            {
                quantite = (stocks[nom] < 0) ? 0 : stocks[nom];
                return true;
            }
            return false;
        }

        public int TotaliserStocks()
        {
            int totalStock = 0;
            foreach (KeyValuePair<string, int> BoissonStock in stocks)
            {
                totalStock += (BoissonStock.Value > 0) ? BoissonStock.Value : 0;
            }
            return totalStock;
        }

        public bool Distribuer(string nom)
        {
            if (BoissonDisponible(nom, out int quantite) && quantite > 0)
            {
                stocks[nom]--;
                return true;
            }
            return false;
        }

        public string AfficherMenu()
        {
            string userAnswer;
            do
            {
                foreach (KeyValuePair<string, int> boissonStock in stocks)
                {
                    if (boissonStock.Value > 0)
                    {
                        Console.WriteLine(boissonStock.Key);
                    }
                }
                Console.WriteLine("Veuillez choisir une boisson disponible : ");
                userAnswer = Console.ReadLine();
            } while (!BoissonDisponible(userAnswer, out int quantite) || quantite <= 0);
            return userAnswer;
        }

        public void Demarrer(Dictionary<string, int> initialStocks = null)
        {
            /*
            if (initialStocks == null)
            {
                initialStocks = new Dictionary<string, int> {
                                                    { "Test1",5 },
                                                    { "Test2", 2 },
                                                    { "Test3", 0 }
                                                            };
            }*/

            initialStocks ??= new Dictionary<string, int> {
                                                    { "Test1",5 },
                                                    { "Test2", 2 },
                                                    { "Test3", 0 }
                                                            };
            stocks = initialStocks;
            while (TotaliserStocks() > 0)
            {
                string choix = AfficherMenu();
                if(Distribuer(choix))
                {
                    Console.WriteLine($"Voici votre {choix}!");
                }
                else
                {
                    Console.WriteLine($"{choix} indisponible...");
                }
            }
        }
    }
}

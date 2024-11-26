namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Distributeur d = new Distributeur();
            d.Demarrer(new Dictionary<string, int> {
                                                    { "Soda",3 },
                                                    { "Orangeade", 2 },
                                                    { "Citronade", 1 },
                                                    { "Eau", 5 }
                                                            });
        }
    }
}

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un premier nombre : ");
            bool isConvertedNb1 = int.TryParse(Console.ReadLine(), out int nb1);
            Console.WriteLine("Veuillez entrer un second nombre : ");
            bool isConvertedNb2 = int.TryParse(Console.ReadLine(), out int nb2);
            Console.WriteLine($"Le nombre 1 a bien été encodé? {isConvertedNb1}");
            Console.WriteLine($"Le nombre 2 a bien été encodé? {isConvertedNb2}");
            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
        }
    }
}

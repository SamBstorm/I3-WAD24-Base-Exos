namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exo version Parse
            Console.WriteLine("Veuillez entrer un premier nombre : ");
            int nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un second nombre : ");
            int nb2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");

            //A ne pas reproduire...
            //Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));
        }
    }
}

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer un nombre (entier) : ");
            string? userInput = Console.ReadLine();
            bool isConverted = int.TryParse(userInput, out int userNb);
            if (!isConverted) {
                Console.WriteLine("On avait dit un nombre entier...");
            }
            else {
                if(userNb / 2 + userNb / 2 == userNb)
                {
                    Console.WriteLine($"Le nombre {userNb} est pair.");
                }
                else
                {
                    Console.WriteLine($"Le nombre {userNb} est impair.");
                }
            }
        }
    }
}

namespace Ex04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Veuillez introduire un premier nombre :");
			string userInput = Console.ReadLine();
			bool isConverted = int.TryParse(userInput, out int nb1);
			if (!isConverted)
			{
				Console.WriteLine($"\"{userInput}\" n'est pas un nombre entier...");
			}
			else
			{
				Console.WriteLine("Veuillez introduire un second nombre :");
				userInput = Console.ReadLine();
				isConverted = int.TryParse(userInput, out int nb2);
				if (!isConverted)
				{
					Console.WriteLine($"\"{userInput}\" n'est pas un nombre entier...");
				}
				else
				{
					/*int resultDivEntiere = nb1 / nb2;
					Console.WriteLine($"Division entière : {resultDivEntiere}");*/
					Console.WriteLine($"Division entière : {nb1 / nb2}");
					Console.WriteLine($"Modulo : {nb1 % nb2}");
					Console.WriteLine($"Division : {(float)nb1 / nb2}");
				}
			}
		}
	}
}

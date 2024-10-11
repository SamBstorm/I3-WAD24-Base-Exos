namespace Ex10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int MINVAL = 1;
			const int MAXVAL = 100;
			Random RNG = new Random();
			int cpuNumber = RNG.Next(MINVAL,MAXVAL+1);

			Console.WriteLine("Bievenue au jeu du \"C'est plus! C'est moins!\"");
			int playerNumber;
			do
			{
				Console.WriteLine($"Joueur veuillez proposer un nombre (entre {MINVAL} et {MAXVAL}) :");
			} while (!int.TryParse(Console.ReadLine(), out playerNumber) || playerNumber < MINVAL || playerNumber > MAXVAL);

			int triesCount = 1;

			while(playerNumber != cpuNumber)
			{
				if(playerNumber > cpuNumber)
				{
					Console.WriteLine("C'est moins!");
				}
				else
				{
					Console.WriteLine("C'est plus!");
				}
				do
				{
					Console.WriteLine($"Veuillez réessayer avec un nouveau nombre (entre {MINVAL} et {MAXVAL}) :");
				} while (!int.TryParse(Console.ReadLine(), out playerNumber) || playerNumber < MINVAL || playerNumber > MAXVAL);
				triesCount++;
			}
			Console.WriteLine($"Félicitation Joueur! Vous avez trouvé le bon numéro : {cpuNumber}; en {triesCount} tentative{((triesCount >1)? "s" : "")}.");
		}
	}
}

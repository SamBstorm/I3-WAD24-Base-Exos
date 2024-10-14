namespace Ex14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int MINJOUEUR = 2;
			const int MAXJOUEUR = 10;
			int nbJoueurs;
			do
			{
				Console.WriteLine($"Veuillez indiquer le nombre de joueur (de {MINJOUEUR} à {MAXJOUEUR} joueurs) :");
			} while (!int.TryParse(Console.ReadLine(), out nbJoueurs) || nbJoueurs < MINJOUEUR || nbJoueurs > MAXJOUEUR);
			int[] scores = new int[nbJoueurs];

			for (int i = 0; i < nbJoueurs; i++)
			{
				do
				{
					Console.WriteLine($"Veuillez indiquer le score du joueur {i + 1} :");
				} while (!int.TryParse(Console.ReadLine(), out scores[i]));
			}

			double total = 0;
			for (int i = 0; i < nbJoueurs; i++) { 
				total += scores[i];
			}

			double moyenne = total / nbJoueurs;

			Console.WriteLine($"La moyenne des scores de nos {nbJoueurs} joueurs est de {moyenne}.");
		}
	}
}

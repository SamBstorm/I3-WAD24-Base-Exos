namespace Ex12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int nbTiret;
			do
			{
				Console.WriteLine("Veuillez introduire le nombre de tiret: ");
			} while (!int.TryParse(Console.ReadLine(), out nbTiret) || nbTiret < 0);

			int nbEspace;
			do
			{
				Console.WriteLine("Veuillez introduire le nombre d'espace: ");
			} while (!int.TryParse(Console.ReadLine(), out nbEspace) || nbEspace < 0);

			int nbRepetition;
			do
			{
				Console.WriteLine("Veuillez introduire le nombre de répétition: ");
			} while (!int.TryParse(Console.ReadLine(), out nbRepetition) || nbRepetition < 0);

			string tirets = "";
			string espaces = "";

			for (int i = 1; i <= nbTiret; i++) {
				tirets += "-";
			}

			for (int i = 1; i <= nbEspace; i++)
			{
				espaces += " ";
			}

			for (int i = 1; i <= nbRepetition; i++) {
				Console.Write($"{tirets}{espaces}");
			}
		}
	}
}

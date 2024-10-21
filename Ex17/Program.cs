namespace Ex17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			
			//Initialisation
			bool[] tab = new bool[10];
			//int index = 0;
			tab[0] = true;

			string userChoice;

			
			do
			{
				//Affichage
				Console.Clear();
				for (int i = 0; i < tab.Length; i++)
				{
					if (tab[i])
					{
						Console.Write("😅");
					}
					else
					{
						Console.Write("⏹️");
					}
				}
				Console.WriteLine();

				//Menu de choix
				Console.WriteLine("(G)auche | (D)roite | (Q)uitter");
				userChoice = Console.ReadLine().ToUpper();
				int index = Array.IndexOf(tab, true);

				//Déplacement
				tab[index] = false;
				if (userChoice == "G" && index > 0)
				{
					index--;
				}
				else if (userChoice == "D" && index < tab.Length - 1)
				{
					index++;
				}
				tab[index] = true;

			} while (userChoice != "Q");
		}
	}
}

namespace Ex18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Dictionary<int, string> game = new Dictionary<int, string>();

			game.Add(0, "Pierre");
			game.Add(1, "Papier");
			game.Add(2, "Ciseaux");

			Random RNG = new Random();
			string answer;

			do
			{
				Console.WriteLine("Choisissez une valeur entre :");
				Console.WriteLine("Pierre - Papier - Ciseaux");
				Console.WriteLine("Pour (Q)uitter");
				int computerChoice = RNG.Next(3);
				answer = Console.ReadLine().ToLower();
				switch (answer) {
					case "pierre":
						if(computerChoice == 1)
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, c'est lui qui gagne...");
						}
						else if(computerChoice == 2){
							 Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, c'est vous qui gagnez!");
						}
						else
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, égalité!");
						}
						break;

					case "papier":
						if (computerChoice == 2)
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, c'est lui qui gagne...");
						}
						else if (computerChoice == 0)
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, c'est vous qui gagnez!");
						}
						else
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, égalité!");
						}
						break;
					case "ciseaux":
						if (computerChoice == 0)
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, c'est lui qui gagne...");
						}
						else if (computerChoice == 1)
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, c'est vous qui gagnez!");
						}
						else
						{
							Console.WriteLine($"Le choix du CPU est {game[computerChoice]}, égalité!");
						}
						break;
				}
			}while (answer != "q");
			*/


			Dictionary<string,string> choices = new Dictionary<string,string>();
			choices.Add("papier", "ciseaux");
			choices.Add("ciseaux", "pierre");
			choices.Add("pierre", "papier");

			Random RNG = new Random();

			string userChoice;
			do {
				Console.WriteLine("Choisissez une valeur entre :");
				Console.WriteLine("Pierre - Papier - Ciseaux");
				Console.WriteLine("Pour (Q)uitter");
				int computerChoice = RNG.Next(3);
				string cpuChoice = choices.Keys.ToArray()[computerChoice];
				userChoice = Console.ReadLine().ToLower();
				if (userChoice != "q")
				{
					if (userChoice == cpuChoice.ToLower())
					{
						Console.WriteLine($"Le choix du CPU est {cpuChoice}, égalité!");
					}
					else if (choices[userChoice] == cpuChoice)
					{
						Console.WriteLine($"Le choix du CPU est {cpuChoice}, vous avez perdu...");
					}
					else
					{
						Console.WriteLine($"Le choix du CPU est {cpuChoice}, vous avez gagné!");
					}
				}
			}
			while (userChoice != "q");
		}
	}
}

namespace Ex16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> todolist = new List<string>();

			string userChoice;
			do
			{
				Console.Clear();
				Console.WriteLine("Voici votre liste de tâches :");
				for(int i = 0; i < todolist.Count; i++)
				{
					string task = todolist[i];
					Console.WriteLine($"{i+1} - {task}");
				}
				Console.WriteLine("Veuillez faire un choix :");
				Console.WriteLine($"(A)jouter - {((todolist.Count>0)?"(S)upprimer - (M)odifier - " : "")}(Q)uitter");
				userChoice = Console.ReadLine().ToUpper();
				int index;
				switch (userChoice)
				{
					case "A":
						Console.WriteLine("Veuillez indiquer la nouvelle tâche :");
						todolist.Add(Console.ReadLine());
						break;
					case "S" when todolist.Count > 0:
						do
						{
							Console.WriteLine("Veuillez sélectionner la tâche à supprimer :");
						} while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > todolist.Count);
						todolist.Remove(todolist[index - 1]);
						break;
					case "M" when todolist.Count > 0:
						do
						{
							Console.WriteLine("Veuillez sélectionner la tâche à modifier :");
						} while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > todolist.Count);
						Console.WriteLine($"Par quoi remplacer \"{todolist[index-1]}\" ?");
						todolist[index - 1] = Console.ReadLine();
						break;
				}
			} while (userChoice != "Q");
			Console.WriteLine("Merci d'utiliser ToDo 3000 !");
		}
	}
}

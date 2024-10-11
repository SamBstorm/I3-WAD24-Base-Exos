namespace Ex09
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string SYMBOL = "⭐";

			Console.OutputEncoding = System.Text.Encoding.Unicode;

			bool inputParsable;
			int userNb = 0;
			do
			{
				Console.WriteLine("Veuillez introduire un entier supérieur à 0 :");
				string userInput = Console.ReadLine();
				inputParsable = int.TryParse(userInput, out userNb);
			} while (!inputParsable || userNb < 1);
			
			/*
			string current = "";
			for (int i = 1; i <= userNb; i++)
			{
				current += SYMBOL;
				Console.WriteLine(current);
			}*/
			for(string current = ""; current.Length <= userNb; current+= SYMBOL)
			{
				Console.WriteLine(current);
			}
		}
	}
}

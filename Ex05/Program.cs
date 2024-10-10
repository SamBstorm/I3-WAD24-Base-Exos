namespace Ex05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Veuillez introduire votre BBAN (12 chiffres): ");
			string userInput = Console.ReadLine();
			if(userInput.Length != 12 || !long.TryParse(userInput, out _))
			{
				Console.WriteLine("Entrée invalide");
			}
			else
			{
				string tenFirstChars = userInput.Substring(0,10);
				string twoLastChars = userInput.Substring(10);
				long tenFirst = long.Parse(tenFirstChars);
				short twoLast = short.Parse(twoLastChars);
				if( tenFirst % 97 == twoLast || (tenFirst % 97 == 0 && twoLast == 97))
				{
					Console.WriteLine("OK");
				}
				else
				{
					Console.WriteLine("KO");
				}
			}
		}
	}
}

namespace Ex06
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Veuillez introduire votre BBAN (12 chiffres): ");
			string userInput = Console.ReadLine();
			if (userInput.Length != 12 || !long.TryParse(userInput, out _))
			{
				Console.WriteLine("Entrée invalide");
			}
			else
			{
				string tenFirstChars = userInput.Substring(0, 10);
				string twoLastChars = userInput.Substring(10);
				long tenFirst = long.Parse(tenFirstChars);
				short twoLast = short.Parse(twoLastChars);
				if (tenFirst % 97 == twoLast || (tenFirst % 97 == 0 && twoLast == 97))
				{
					Console.WriteLine("OK");
					string be0 = twoLastChars + twoLastChars + "111400";
					long be0Nb = long.Parse(be0);
					short code = (short)(98 - (be0Nb % 97));
					//string iban = $"BE{code:D2}{userInput}";
					string iban = $"BE{((code < 10) ? "0" : "")}{code}{userInput}";
					Console.WriteLine($"Votre IBAN est : {iban}");
				}
				else
				{
					Console.WriteLine("KO");
				}
			}
		}
	}
}

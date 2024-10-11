namespace Ex08
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int table = 1;
			while (table <= 9)
			{
				int multiplicateur = 1;
				while (multiplicateur <= 10)
				{
					Console.WriteLine($"{table} x {multiplicateur} = {table * multiplicateur}");
					multiplicateur++;
				}
				table++;
			}
		}
	}
}

namespace Ex07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int TABLE = 2;

			/* WHILE */
			int multiplicateur = 1;
			while (multiplicateur <= 10)
			{
				Console.WriteLine($"{TABLE} x {multiplicateur} = {TABLE * multiplicateur}");
				multiplicateur++;
			}
			
			/*FOR
			for (int multiplicateur = 1;multiplicateur <= 10;multiplicateur++)
			{
				Console.WriteLine($"{TABLE} x {multiplicateur} = {TABLE * multiplicateur}");
			}
			*/
			/*DO...WHILE
			int multiplicateur = 1;
			do
			{
				Console.WriteLine($"{TABLE} x {multiplicateur} = {TABLE * multiplicateur}");
				multiplicateur++;
			} while (multiplicateur <= 10);*/
		}
	}
}

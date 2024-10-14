namespace Ex15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random RNG = new Random();
			const int SIZE = 7;
			int[] tab = new int[SIZE];

			for (int i = 0; i < SIZE; i++) {
				tab[i] = RNG.Next(1,11);
			}

			Console.WriteLine("Tableau initial :");
			foreach (int value in tab)
			{
				Console.WriteLine(value);
			}
			Console.WriteLine();

			for (int i = 0; i < (SIZE/2) ; i++) {
				int temp = tab[i];
				tab[i] = tab[SIZE - 1 - i];
				tab[SIZE - 1 - i] = temp;
			}

			Console.WriteLine("Tableau inversé :");
			foreach (int value in tab)
			{
				Console.WriteLine(value);
			}
		}
	}
}

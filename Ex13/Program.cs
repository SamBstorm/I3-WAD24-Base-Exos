namespace Ex13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int SIZE = 10;
			int[] tab = new int[SIZE];

			/*tab[0] = 2;
			for (int i = 1; i < tab.Length; i++) {
				tab[i] = tab[i - 1] * 2;
			}*/

			for (int i = 0; i < tab.Length; i++) {
				tab[i] = (int)Math.Pow(2, (i + 1));
			}

			foreach (int value in tab) {
				Console.WriteLine(value);
			}
		}
	}
}

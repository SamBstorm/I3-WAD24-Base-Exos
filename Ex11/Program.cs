namespace Ex11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int nb;
			do
			{
				Console.WriteLine("Veuillez introduire un premier nombre : "); 
			} while (!int.TryParse(Console.ReadLine(), out nb));

			int smallest = nb;

			for (int i = 1; i < 10; i++)
			{
				do
				{
					Console.WriteLine("Veuillez introduire un nouveau nombre : ");
				} while (!int.TryParse(Console.ReadLine(), out nb));
				if(nb < smallest)
				{
					smallest = nb;
				}
				//smallest = (nb < smallest) ? nb : smallest;
			}
			Console.WriteLine($"Le plus petit nombre de la série est {smallest}.");
		}
	}
}

namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, quelle température fait-il à Bruxelles actuellement ? (en Celsius) ?");

            Celsius c_bru = new Celsius();

            c_bru.temperature = double.Parse(Console.ReadLine());

            Console.WriteLine($"Waouw! Si nous étions à New-York, on dirait en Fahrenheit qu'il fait {c_bru.Convert().temperature} °F.");

            Console.WriteLine("Et quelle température fait-il actuellement à New-York? (En Fahrenheit)");

            Fahrenheit f_ny = new Fahrenheit();
            f_ny.temperature = double.Parse(Console.ReadLine());

            Console.WriteLine($"Mais comme nous sommes à Bruxelles, nous parlons en celsius : {f_ny.Convert().temperature} °C.");
        }
    }
}

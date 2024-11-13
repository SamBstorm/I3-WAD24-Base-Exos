namespace Exo19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcul calc1;
            do
            {
                Console.WriteLine("Veuillez introduire un premier nombre :");
            }while (!double.TryParse(Console.ReadLine(), out calc1.nb1));

            do
            {
                Console.WriteLine("Veuillez introduire un opérateur (+, -, *, /) :");
                calc1.operat = Console.ReadLine()[0];
            } while (
                calc1.operat != '+' 
                && calc1.operat != '-' 
                && calc1.operat != '*' 
                && calc1.operat != '/');

            do
            {
                Console.WriteLine("Veuillez introduire un second nombre :");
            } while (!double.TryParse(Console.ReadLine(), out calc1.nb2));

            calc1.isValid = true;
            switch (calc1.operat)
            {
                case '+':
                    calc1.result = calc1.nb1 + calc1.nb2;
                    break;
                case '-':
                    calc1.result = calc1.nb1 - calc1.nb2;
                    break;
                case '*':
                    calc1.result = calc1.nb1 * calc1.nb2;
                    break;
                case '/':
                    if(calc1.nb2 == 0)
                    {
                        calc1.result = null;
                        calc1.isValid = false;
                    }
                    else
                    {
                        calc1.result = calc1.nb1 / calc1.nb2;
                    }
                    break;
                default:
                    calc1.result = null;
                    calc1.isValid = false;
                    break;
            }

            if (calc1.isValid && calc1.result is not null)
            {
                Console.WriteLine($"Le résultat de {calc1.nb1} {calc1.operat} {calc1.nb2} vaut {calc1.result}");
            }
            else if (calc1.isValid)
            {
                Console.WriteLine($"Le résultat de {calc1.nb1} {calc1.operat} {calc1.nb2} n'a pas encore été calculé...");
            }
            else
            {
                Console.WriteLine($"Il n'y a pas de résultat pour {calc1.nb1} {calc1.operat} {calc1.nb2}");
            }
        }
    }
}

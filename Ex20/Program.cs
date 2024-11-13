namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> contacts = new List<Person>();

            char userChoice;
            do
            {
                Console.Clear();
                if (contacts.Count > 0)
                {
                    foreach (Person p in contacts)
                    {
                        Console.WriteLine($"{p.lastname} {p.firstname}");
                        if (p.birthdate is not null)
                        {
                            Console.WriteLine($"Né le {((DateTime)p.birthdate).ToShortDateString()}");
                        }
                        if (p.address is not null)
                        {
                            Address a = (Address)p.address;
                            Console.WriteLine($"{a.street} {a.number}\n{a.zipCode} {a.city}\n{a.country.ToUpper()}");
                        }
                        Console.WriteLine("----------------");
                    }
                }
                else
                {
                    Console.WriteLine("Il n'y a pas encore de contacts...");
                }

                Console.WriteLine("\n(A)jouter - (M)odifier - (S)upprimer - (Q)uitter");
                userChoice = Console.ReadLine().ToUpper()[0];
                switch (userChoice)
                {
                    case 'A':
                        //Ajout contact
                        Person contact;
                        Console.WriteLine("Veuillez indiquer le nom de famille de votre nouveau contact :");
                        contact.lastname = Console.ReadLine();
                        Console.WriteLine("Veuillez indiquer le prénom de votre nouveau contact :");
                        contact.firstname = Console.ReadLine();
                        string dateValue;
                        bool isConverted;
                        do
                        {
                            Console.WriteLine("Veuillez introduire la date de naissance au format jj-mm-aaaa : (ne rien introduire si aucune date) ");
                            DateTime birthdate;
                            dateValue = Console.ReadLine();
                            isConverted = DateTime.TryParse(dateValue, out birthdate); 
                        } while (dateValue.Length > 0 && !isConverted);

                        break;
                    case 'M':
                        //Mettre à jour le contact
                        break;
                    case 'S':
                        //Supprimer le contact
                        break;
                } 
            } while (userChoice != 'Q');
        }
    }
}

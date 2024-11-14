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
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        Person p = contacts[i];
                        Console.WriteLine($"{i + 1}. {p.lastname} {p.firstname}");
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

                int indexContact;
                Person contact = new Person();

                string dateValue;
                bool isConverted;
                DateTime birthdate;

                switch (userChoice)
                {
                    case 'A':
                        //Ajout contact
                        Console.WriteLine("Veuillez indiquer le nom de famille de votre nouveau contact :");
                        contact.lastname = Console.ReadLine();
                        Console.WriteLine("Veuillez indiquer le prénom de votre nouveau contact :");
                        contact.firstname = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Veuillez introduire la date de naissance au format jj-mm-aaaa : (ne rien introduire si aucune date) ");
                            dateValue = Console.ReadLine();
                            isConverted = DateTime.TryParse(dateValue, out birthdate); 
                        } while (dateValue.Length > 0 && !isConverted);
                        contact.birthdate = (dateValue.Length == 0) ? null : birthdate;
                        Console.WriteLine("Voulez-vous ajouter une adresse ? (O)ui - (N)on");
                        if (Console.ReadLine().ToUpper()[0] == 'O')
                        {
                            Address contactAddress;
                            Console.WriteLine("Veuillez indiquer la rue :");
                            contactAddress.street = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer le numéro :");
                            contactAddress.number = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer la ville :");
                            contactAddress.city = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer le code postal :");
                            contactAddress.zipCode = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer le pays :");
                            contactAddress.country = Console.ReadLine().Trim();

                            contact.address = contactAddress;
                        }
                        contacts.Add(contact);
                        break;
                    case 'M' when contacts.Count > 0:
                        //Mettre à jour le contact
                        do
                        {
                            Console.WriteLine($"Veuillez indiquer l'identifiant du contact (entre 1 et {contacts.Count} ) :");
                        } while (!int.TryParse(Console.ReadLine(), out indexContact) || indexContact < 1 || indexContact > contacts.Count);
                        indexContact--;

                        contact = contacts[indexContact];

                        Console.WriteLine($"Le contact a pour nom de famille : {contact.lastname}\nVoulez-vous le modifier ? (O)ui - (N)on");
                        if (Console.ReadLine().ToUpper()[0] == 'O')
                        {
                            Console.WriteLine("Veuillez indiquer le nouveau nom de famille :");
                            contact.lastname = Console.ReadLine();
                        }
                        Console.WriteLine($"Le contact a pour prénom : {contact.firstname}\nVoulez-vous le modifier ? (O)ui - (N)on");
                        if (Console.ReadLine().ToUpper()[0] == 'O')
                        {
                            Console.WriteLine("Veuillez indiquer le nouveau prénom :");
                            contact.firstname = Console.ReadLine();
                        }

                        if(contact.birthdate is null)
                        {
                            Console.WriteLine("Actuellement, le contact n'a pas de date de naissance.\n En ajouter une ? (O)ui - (N)on");
                        }
                        else
                        {
                            Console.WriteLine($"Actuellement, la date de naissance du contact et {((DateTime)contact.birthdate).ToShortDateString()}.\n La modifier ? (O)ui - (N)on");
                        }
                        if (Console.ReadLine().ToUpper()[0] == 'O')
                        {
                            do
                            {
                                Console.WriteLine("Veuillez introduire la date de naissance au format jj-mm-aaaa : (ne rien introduire si aucune date) ");
                                dateValue = Console.ReadLine();
                                isConverted = DateTime.TryParse(dateValue, out birthdate);
                            } while (dateValue.Length > 0 && !isConverted);
                            contact.birthdate = (dateValue.Length == 0) ? null : birthdate;
                        }
                        if(contact.address is null)
                        {
                            Console.WriteLine("Actuellement, le contact n'a pas d'adresse'.\n En ajouter une ? (O)ui - (N)on");
                        }
                        else
                        {
                            Address a = (Address)contact.address;
                            Console.WriteLine($"Actuellement, l'adresse du contact est :\n{a.street} {a.number}\n{a.zipCode} {a.city}\n{a.country.ToUpper()}.\n La modifier ? (O)ui - (N)on");
                        }
                        if (Console.ReadLine().ToUpper()[0] == 'O')
                        {
                            Address contactAddress;
                            Console.WriteLine("Veuillez indiquer la rue :");
                            contactAddress.street = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer le numéro :");
                            contactAddress.number = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer la ville :");
                            contactAddress.city = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer le code postal :");
                            contactAddress.zipCode = Console.ReadLine().Trim();
                            Console.WriteLine("Veuillez indiquer le pays :");
                            contactAddress.country = Console.ReadLine().Trim();

                            contact.address = contactAddress;
                        }

                        contacts[indexContact] = contact;
                        
                        break;
                    case 'S' when contacts.Count > 0:
                        //Supprimer le contact
                        do
                        {
                            Console.WriteLine($"Veuillez indiquer l'identifiant du contact (entre 1 et {contacts.Count} ) :");
                        } while (!int.TryParse(Console.ReadLine(), out indexContact) || indexContact < 1 || indexContact > contacts.Count);
                        indexContact--;
                        contacts.RemoveAt(indexContact);
                        break;
                } 
            } while (userChoice != 'Q');
        }
    }
}

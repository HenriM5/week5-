using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su nimi?");
                
            String UserFirstName = Console.ReadLine();

            Console.WriteLine($"Cool. Mis on su perekonnanimi?");

            String UserLastName = Console.ReadLine();

            Console.WriteLine($"Su eesnimi on {UserFirstName.Length} sümbolit pikk aga su perekonnanimi on {UserLastName.Length} sümbolit pikk");

            if (UserFirstName.Length > UserLastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");

            }
            else if (UserFirstName.Length < UserLastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem, kui eesnimi.");
            }
             else
            {
                Console.WriteLine("sama pikad.");
            }

            

            
        }
    }
}

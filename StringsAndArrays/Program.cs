using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestqda eesinimi;
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("sisesta oma eesnimi palun");
            String userFirstName = Console.ReadLine();
            Console.WriteLine($"Sinu nimi on {userFirstName.Length} Sümbolit pikk.");
            
            
        }
    }
}

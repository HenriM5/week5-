using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime tagurpidi
            //*eesnimi ja perekonnanimi kuvatakse eraldi
            //kasutame for-tsyklit
            Console.WriteLine("Mis on su eesnimi?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("mis on su perekonna nimi?");

            string LastName = Console.ReadLine();
            
            
            for (int i = FirstName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(FirstName[i]);
                    
            }
            for (int i = FirstName.Length - 1; i >= 0; i--)
            {
                    Console.WriteLine(LastName[i]);
                }

        }
    }
}

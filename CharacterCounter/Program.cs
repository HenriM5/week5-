using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kautajalt sisestada eesnime ja perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja perekonnanimes kokku on
            //char a = 'a';
            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi");
            string lastname = Console.ReadLine();
            string fullName = $"{firstname}{lastname}";
            int counter = 0;
            /* foreach(char character in fullName)
               {
            //     if(character == 'a')
                   {
            //         counter++; 
                   }
               }*/
            // Console.WriteLine($"sinu nimes on {counter} a-tähte");
            int i = fullName.Length - 1;
            while (i >= 0)
            {
                if (fullName[fullName.Length - 1] == 'a')
                {
                    counter++;
                }
                i--;
                Console.WriteLine($"Sinu nimes {counter} a-tähte");
        } }
           
    }    
}

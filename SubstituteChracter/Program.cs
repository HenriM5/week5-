using System;

namespace SubstituteChracter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi");
            string lastname = Console.ReadLine();
            string fullname = ($"{firstname}{lastname}".ToLower);
            fullname = fullname.Replace('a', '*');
            Console.WriteLine(fullname);
           

            
        }
    }
}

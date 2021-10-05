using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna pikkust Length omaduse kasutamata

            //Foreach Loop
            //ForEach(Element in string)

            string HelloWorld = "Hello World!";
            int counter = 0;
                foreach(char character in HelloWorld)
            {

                counter = counter + 1;
                
            }
            Console.WriteLine($"{HelloWorld} on {counter} sümbolit pikk");
        }
    }
}

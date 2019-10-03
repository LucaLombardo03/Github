using System;

namespace CiaoMondo
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            Console.WriteLine("Sei italiano o inglese?");
            risposta = Console.ReadLine();
            if (risposta == "italiano")
                Console.WriteLine("Ciao Mondo");
            else if (risposta == "inglese")
                Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}

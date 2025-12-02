using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (j/n)");
            string svar = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (svar == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig!");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
        }
    }
}

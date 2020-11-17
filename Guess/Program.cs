using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
             bool pobjeda = false;

            while(pobjeda == false)
            {   int sto = 100;
                sto++;
                Console.WriteLine(sto);
                Random broj = new Random();
            int pobjednickiBroj = broj.Next(0,sto);
            Console.WriteLine(pobjednickiBroj);

            Console.WriteLine("Upisite broj");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a == pobjednickiBroj)
            {
                Console.WriteLine("Pobjedili ste");
                pobjeda = true;
                
            }
            else{
                ++sto;
                Console.WriteLine("Izgubili ste");
                Console.WriteLine("");
            }

            }
        }
    }
}

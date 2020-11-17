using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pobjeda = false;
            int sto = 100;
            int pokusaj = 1;
            double nagrada = 100;
            
            Console.WriteLine("Morate pogoditi broj između 0 i 100.");
            Console.WriteLine("Nagrada iznosi 100 kuna.");
            Console.WriteLine("Svaki novi pokušaj će vam umanjiti nagradu za 25%");     
            Console.WriteLine("");

            while(pobjeda == false)
            {   
                
               
                Random broj = new Random();
            int pobjednickiBroj = broj.Next(0,sto);
            Console.WriteLine("pobjednicki" + pobjednickiBroj);
            
           
            if(pokusaj <= 3)
            {
            bool parse = false;
            int a = 0;
            
            while(parse == false)
            {
  
            Console.WriteLine("Pokušaj broj: " + pokusaj);
            Console.WriteLine("Upišite broj:");
            string pogadaj = Console.ReadLine();
            
            
            parse = int.TryParse(pogadaj, out a);
            }
            
            
          
            Console.WriteLine("");
            if(a == pobjednickiBroj)
            {
                Console.WriteLine("Pobjedili ste i osvojili " + nagrada + " kuna.");
                pobjeda = true;
                
            }
            else if(a != pobjednickiBroj){
                pokusaj++;
                nagrada *= 0.75;
                
            }

            }else
            {
                Console.WriteLine("Izgubili ste");
                pobjeda = true;
            }
                     
            

            }
        }
    }
}

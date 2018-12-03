using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_paskaita_2018_12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kintamieji zodziai = new Kintamieji();
            //zodziai.Kintamasis1 = "Sveikas";

            //zodziai.Kintamasis3 = "va";
            //zodziai.Kintamasis4 = "zodis";
            Console.WriteLine(zodziai.Kintamasis1);
            Console.WriteLine(zodziai.Kintamasis2);
            //Console.WriteLine(zodziai.Kintamasis3);
            Console.WriteLine(zodziai.Kintamasis4);
            
            Console.ReadKey();
        }
    }
}

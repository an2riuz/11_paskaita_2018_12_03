using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_paskaita_2018_12_03
{
    class Kintamieji
    {
        private string kintamasis1 = "Labas";
        private string kintamasis2 = "vakaras";
        private string kintamasis3 = "stai";
        private string kintamasis4 = "ir as";

        public Kintamieji()
        {
            
        }
        public string Kintamasis1
        {
            get { return kintamasis1; }
            set { kintamasis1 = value; }
        }
        public string Kintamasis2
        {
            get { return kintamasis2; }
        }
        public string Kintamasis3
        {
            set { kintamasis3 = value; }
        }
        public string Kintamasis4 { get; private set; }
    }
}

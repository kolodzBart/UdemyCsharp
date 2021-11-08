using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharp
{
    class Obywatel
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }



        public Obywatel(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }
    }
}

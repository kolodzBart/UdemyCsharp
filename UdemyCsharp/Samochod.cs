using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharp
{
    class Samochod
    {
        class Silnik
        {
            public Silnik(uint moc = 500)
            {
                this.Moc = moc;
                //Console.WriteLine("Ja jestem z konstruktora silnik");
            }
            public uint Moc;
        }

        public Samochod()
            {
            silnik = new Silnik();
            //Console.WriteLine("Ja jestem z konstruktora samochód");
            silnik.Moc = 700;
            }

        private Silnik silnik;

        public uint pobierzMoc()
        {
            return this.silnik.Moc;
        }

    }
}

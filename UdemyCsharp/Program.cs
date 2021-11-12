using System;

namespace UdemyCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Abs(-66));
            //Console.ReadLine();
            //int a = 10;
            //Math.IncreaseBy5(ref a);
            //Console.WriteLine(a);

            //int b;
            //Math.Zeruj(out b);
            //Console.WriteLine(b);

            //Console.WriteLine(Math.Dodaj(1, 2, 4, 3));

            //Console.WriteLine(Math.Poteguj(2));

            //Obywatel Obywatel1 = new Obywatel(imie:"Arek", nazwisko:"test");
            //Console.WriteLine(Obywatel1.Imie);

            //Gracz[] gracz = new Gracz[3];
            //gracz[0] = new Gracz("Morfidon");
            //gracz[1] = new Gracz("Tescior");
            //gracz[2] = new Gracz("Monti");

            //gracz[1].Nick = "lala";

            //Console.WriteLine(gracz[0].Nick);
            //Console.WriteLine(gracz[0].Id);
            //Console.WriteLine(gracz[1].Nick);
            //Console.WriteLine(gracz[1].Id);
            //Console.WriteLine(gracz[2].Nick);
            //Console.WriteLine(gracz[2].Id);

            //Console.WriteLine(Welcomer.Message);

            //Car samochod = new Car("Toyota");
            //Console.WriteLine(samochod.NrOfWheels);

            //Car samochod2 = new Car("Seat", 5);
            //Car samochod3 = new Car(samochod2);

            Samochod samochod = new Samochod();
            Console.WriteLine(samochod.pobierzMoc());
        }
    } 
}

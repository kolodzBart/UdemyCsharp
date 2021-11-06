using System;

namespace UdemyCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Abs(-66));
            //Console.ReadLine();
            int a = 10;
            Math.IncreaseBy5(ref a);
            Console.WriteLine(a);

            int b;
            Math.Zeruj(out b);
            Console.WriteLine(b);

            Console.WriteLine(Math.Dodaj(1, 2, 4, 3));

            Console.WriteLine(Math.Poteguj(2));

            Obywatel Obywatel1 = new Obywatel(imie:"Arek", nazwisko:"test");
            Console.WriteLine(Obywatel1.Imie);
        }
    }

    class Math
    {
        public static int Abs(int X)
        {
            if (X < 0)
            {
                return X * (-1);
            }
            else
                return X;
        }

        public static int IncreaseBy5(ref int nr)
        {
            nr += 5;
            return nr;
        }

        public static void Zeruj(out int b)
        {
            b = 0;
        }

        public static int Dodaj(params int[] args)
        {
            int suma = 0;
            for (int i = 0; i<args.Length; i++)
            {
                suma = suma + args[i];
            }
            return suma;
        }

        public static int Poteguj(int podstawa_potegi, int wykladnik=2)
        {
            int tmp = 1;
            for (int i=0; i<wykladnik; i++)
            {
                tmp = tmp * podstawa_potegi;

            }
            return tmp;
        }
    }

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

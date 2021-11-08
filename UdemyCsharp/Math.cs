using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharp
{
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
            for (int i = 0; i < args.Length; i++)
            {
                suma = suma + args[i];
            }
            return suma;
        }

        public static int Poteguj(int podstawa_potegi, int wykladnik = 2)
        {
            int tmp = 1;
            for (int i = 0; i < wykladnik; i++)
            {
                tmp = tmp * podstawa_potegi;

            }
            return tmp;
        }
    }
}

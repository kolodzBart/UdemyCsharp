using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharp
{
    class Welcomer
    {
        public static string  Message
        {
            get;
            private set;
        }

        static Welcomer()
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 17)
            {

                Message = "Dzień dobry";
            }
            else
            {
                Message = "Dobry wieczór";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharp
{
    class Gracz
    {
        string nick;
        int id;
        static int nastepneId;

        public Gracz ()
        {
            nick = null;
            id = 0;
        }

        public Gracz(string nick)
        {
            this.nick = nick;
            nastepneId++;
            id = nastepneId = 0;

        }

        public String Nick
        {
            get
            {
                return this.nick;

            }
            set
            {
                // jakies warunki np: jesli admin lub jesli oplacone 
                if (value == "lala")
                    {
                     Console.WriteLine("error");

                    }
                else
                this.nick = value;
            }
        }

        public string Id
        {
            get
            {
                return "your ID is " + this.id;
            }
        }

        public int NastepneID
        {
            get
            {
                return nastepneId;
            }
        }
    }
}

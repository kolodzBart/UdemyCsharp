using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharp
{
    class Car
    {
        public string Description
        {
            get;
            set;
        }

        public byte NrOfWheels
        {
            get;
            private set;
        }

        public Car(string description, byte nrOfwheels)
        {
            this.Description = description;
            this.NrOfWheels = nrOfwheels;
        }
        //konstruktor wywoływany z innego kontruktora
        public Car(string description) : this(description,4)
        {
            Console.WriteLine("uruchomiony został konstruktor z innego konstruktora i przypisał ilośc 4 do kół");
        }

        //konstruktor samokopiujący
        public Car(Car samochod)
        {
            this.Description = samochod.Description;
            this.NrOfWheels = samochod.NrOfWheels;

        }
    }
}

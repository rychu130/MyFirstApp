using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    partial class Car:Vehicle //tylko pola i konsruktory
    {
        string petName;
        int Speed;
        public int currSpeed { 
            get { return Speed; } 
            set { Speed = (value <= 200) ? value : 200; } 
        }//właściwość .NET / property

        private Gearbox gear = new Gearbox();

        public Gearbox gears
        {
            get { return gear; }
            set { gear = value; }
        }

        public int getNumberOfGears()
        {
            return gear.numberOfGears;
        }
        
        public Car() {
            petName = " ";
            currSpeed = 0;
        }
        public Car(string petName, int currSpeed = 0) {
            this.petName = petName;
            this.currSpeed = currSpeed;
        }
        
    }
}

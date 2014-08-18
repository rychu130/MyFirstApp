using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    partial class Car:Vehicle,IDisposable //pola
    {
        string petName;
        int Speed;
        public int currSpeed { 
            get { return Speed; } 
            set { Speed = (value <= 200) ? value : 200; } 
        }//właściwość .NET / property
        
        
        public Car() {
            petName = " ";
            currSpeed = 0;
        }
        public Car(string petName, int currSpeed = 0) {
            this.petName = petName;
            this.currSpeed = currSpeed;
        }
        public override string ToString()
        {
            string s = String.Format("{0} \n This is a Car. It's current speed is {1} and it's petName is {2}", base.ToString(), currSpeed, petName);
            return s;
        }
        ~
    }
}

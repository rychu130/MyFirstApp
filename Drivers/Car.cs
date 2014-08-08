using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    class Car:Vehicle
    {
        string petName;
        public int currSpeed { public get; set; }
        
        public Car() {
            petName = " ";
            currSpeed = 0;
        }
        public Car(string petName, int currSpeed = 0) {
            this.petName = petName;
            this.currSpeed = currSpeed;
        }
        
        public void speedUp(int delta)
        {
            currSpeed += delta;
        }
        public void printState() {
            Console.WriteLine("{0} is going {1} km/h", petName, Convert.ToString(currSpeed));//nie wymagane konwertowanie
        }

    }
}

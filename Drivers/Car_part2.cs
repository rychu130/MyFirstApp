using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    partial class Car:Vehicle
    {

        public void speedUp(int delta)
        {
            currSpeed += delta;
        }
        public void printState()
        {
            Console.WriteLine("{0} is going {1} km/h", petName, Convert.ToString(currSpeed));//nie wymagane konwertowanie
        }

    }
}

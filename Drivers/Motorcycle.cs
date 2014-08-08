using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    class Motorcycle:Vehicle
    {
        int speed = 0;
        string driverName;

        public void Ride(){
            Console.WriteLine("Ihaaaa");
        }
        public void speedUp(int delta) {
            speed += delta;
        }
        public void setDriverName(string driverName) {
            this.driverName = driverName;
        }
        public void setSpeed(int speed) {
            this.speed = speed;
        }
    }
}

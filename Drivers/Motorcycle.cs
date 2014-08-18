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
        public override string ToString()
        {
            string s = String.Format("{0} \n This is a Motorcycle. It's current speed is {1} and it's driver's name is {2}", base.ToString(), speed, driverName);
            return s;
        }
    }
}

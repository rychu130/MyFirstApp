using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    class Garage
    {
        Vehicle[] vlist = new Vehicle[10];
        public int numberOfCars { get; set; }

        public int addVehicle(Vehicle v)
        {
            bool success = true;
            foreach (Vehicle vv in vlist){
                if (vv == v) {
                    success = false;
                    Console.WriteLine("Vehicle already on a list");
                    break;
                }
            }
            if (success)
            {
                vlist[numberOfCars] = v;
                numberOfCars++;
                return 1;
            }
            else return 0;
        }

        public void printVehicles()
        {
            foreach (Vehicle v in vlist)
            {
                Console.WriteLine("{0}", v.ToString());// TODO overload Vehicle's ToString method
            }
        }
        public Vehicle[] list {
            get{return vlist;}
        }
        


    }
}

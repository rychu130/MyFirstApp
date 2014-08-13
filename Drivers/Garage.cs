using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    class Garage
    {
        Vehicle[] vlist;
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
                vlist[vlist.Length] = v;
                return 1;
            }
            else return 0;
        }

        public Vehicle[] list {
            get
            {
                return vlist;
            }
        }
        /*public Vehicle[] getVehicles() { 
            return vlist;
        }*/


    }
}

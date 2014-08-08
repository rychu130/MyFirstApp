using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    abstract class Vehicle
    {
        /*protected static string WheelType = "soft";
        public static void changeWheelType(string wheel)
        {
            WheelType = wheel;
        }
        public static string getWheelType()
        {
            return WheelType;
        }*/
        // właściwość .NET
        static string VehicleWheelType = "soft";
        public static string WheelType
        {
            get { return VehicleWheelType; }
            set { VehicleWheelType = value; }
        }
    }
}

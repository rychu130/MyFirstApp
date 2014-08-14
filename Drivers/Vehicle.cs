using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    public enum WheelTypes{soft, medium_soft, medium_hard, hard};
    abstract class Vehicle
    {
        private Gearbox gear;
        public WheelTypes wheelType { get; set; }

        public Vehicle():this(WheelTypes.soft, new Gearbox()) { }
        public Vehicle(WheelTypes wt):this(wt, new Gearbox()) { }
        public Vehicle(WheelTypes wt, Gearbox g){
            gear = g;
            wheelType = wt;
        }
        
        public Gearbox gears
        {
            get { return gear; }
            set { gear = value; }
        }//delegat

        public int getNumberOfGears()
        {
            return gear.numberOfGears;
        }
        

    }
}

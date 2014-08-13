using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    class Gearbox
    {
        private int numberOfGears;
        public int gears
        {
            get { return numberOfGears; }
            set {
                if (type == GearboxType.manual) numberOfGears = value;
                else numberOfGears = 0; //TODO raise exception
            }
        }
        public enum GearboxType { manual, automatic }
        public GearboxType type;
    }
}

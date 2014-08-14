using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    class Gearbox
    {
        private int numOfGears;
        public int numberOfGears//property getting and setting numOfGears
        {
            get { return numOfGears; }
            set {
                if (type == GearboxType.manual) numOfGears = value;
                else numOfGears = 0; //TODO raise exception
            }
        }
        public enum GearboxType { manual, automatic }
        public GearboxType type;
    }
}

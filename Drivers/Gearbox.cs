using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drivers
{
    public enum GearboxType { manual, automatic }
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
        public GearboxType type{get;set;}
        public Gearbox():this(GearboxType.manual){}
        public Gearbox(GearboxType type) {
            this.type = type;
            numberOfGears = 0;
        }
        public Gearbox(GearboxType type, int numOfGears)
        {
            this.type = type;
            this.numberOfGears = numOfGears;
        }
    }
}

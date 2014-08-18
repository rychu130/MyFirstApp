using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Drivers;

namespace Drivers
{
    class mainprog
    {
        public static void Main()
        {
            Car myCar = new Car();
            myCar.speedUp(5);
            myCar.printState();
            myCar.currSpeed = 50;

            Car myCar2 = new Car("Pan Samochodzik", 50);
            myCar2.printState();

            Motorcycle myMotor = new Motorcycle();
            myMotor.setDriverName("AbC");
            myMotor.setSpeed(10);
            myMotor.Ride();
            myMotor.gears.type = GearboxType.manual;
            myCar.currSpeed = 2;
            myMotor.wheelType = WheelTypes.hard;
            Console.WriteLine("Motorcycle wheel: {0}, Car wheel: {1}", Convert.ToString(myMotor.wheelType), myCar.wheelType);
            Garage g = new Garage();
            g.addVehicle(myCar);
            g.addVehicle(myCar2);
            g.addVehicle(myMotor);
            g.printVehicles();
            Car []mynewCar = new Car[100];
            for (int i = 0; i < 100; i++) {
                mynewCar[i] = new Car();
            }
            mynewCar = null;
            GC.WaitForPendingFinalizers();
            
            Console.WriteLine("{0}", GC.GetTotalMemory(false));
            System.Threading.Thread.Sleep(2000);
            System.GC.Collect(1, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("{0}", GC.GetTotalMemory(false));
            Console.ReadLine();
        }
    }
}

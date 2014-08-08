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

            Car myCar2 = new Car("Pan Samochodzik", 50);
            myCar2.printState();

            Motorcycle myMotor = new Motorcycle();
            myMotor.setDriverName("AbC");
            myMotor.setSpeed(10);
            myMotor.Ride();
            myCar.currSpeed = 2;
            Motorcycle.WheelType = "hard";
            Console.WriteLine("Motorcycle wheel: {0}, Car wheel: {1}",Motorcycle.WheelType, Car.WheelType);

            Console.ReadLine();
        }
    }
}

using System;
using Vehicles.Library;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Builders;
using Vehicles.Library.Decorator;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategy;

namespace Vehicles.Console
{
    class Program
    {
        public static void Main()
        {
            var car = new CarBuilder()
                .SetProductionYear(1999)
                .SetBrand("Audi")
                .SetMaxVelosity(300)
                .Build();

            Boat boat = new Boat();
            boat.ChangeMoveStrategy(new DriveStrategy());

            IDecorator vehicle = new Car();
            vehicle = new MachineGunDecorator(vehicle);
            System.Console.WriteLine(vehicle.Weapon());

            CarFacade car1 = new CarFacade();
            car1.CreateCar(1997, "Audi", 3000, 350, Guid.NewGuid(), Color.Black, EngineType.Diesel); 


            System.Console.ReadKey();
        }
    }
}

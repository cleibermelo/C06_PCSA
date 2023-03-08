using E01_OOP_Interfaces_Vehicle.Interface;
using System;

namespace E01_OOP_Interfaces_Vehicle.Class
{

    public class Airplane : Vechicle, IVehicleAir
    {

        #region Enums
        public enum EnumFuel
        {
            Gasoline,
            Diesel,
            Biodiesel,
            Ethanol
        }
        #endregion

        #region Properties
        public EnumFuel Fuel { get; set; }
        #endregion

        #region Constructors
        public Airplane()
        {

            VehicleId = 0;
            Description = string.Empty;
            Model = string.Empty;
            Fuel = EnumFuel.Gasoline;

        }

        public Airplane(int vechicleId, string description, string model, EnumFuel fuel)
        {

            VehicleId = vechicleId;
            Description = description;
            Model = model;
            Fuel = fuel;

        }
        #endregion

        #region Methods
        public void Fly()
        {

            Console.WriteLine($"\nFly - {Description}");

        }
        #endregion

    }

}

using E01_OOP_Interfaces_Vehicle.Interface;
using System;

namespace E01_OOP_Interfaces_Vehicle.Class
{

    public class Car : Vechicle, IVehicleRoad
    {

        #region Enums
        public enum EnumColor
        {
            Red,
            Green,
            Blue
        }
        #endregion

        #region Properties
        public EnumColor Color { get; set; }
        #endregion

        #region Constructors
        public Car()
        {

            VehicleId = 0;
            Description = string.Empty;
            Model = string.Empty;
            Color = EnumColor.Green;

        }

        public Car(int vechicleId, string description, string model, EnumColor color)
        {

            VehicleId = vechicleId;
            Description = description;
            Model = model;
            Color = color;

        }
        #endregion

        #region Methods
        public void Drive()
        {

            Console.WriteLine($"\nDrive - {Description}");

        }
        #endregion

    }

}

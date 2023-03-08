using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01_OOP_Interfaces_Vehicle.Interfaces;

namespace E01_OOP_Interfaces_Vehicle.Classes
{
    public class Airplane : Vehicle, IAirplane
    {
        #region Enums
        public enum EnumFuel
        {
            Gasoline,
            Diesel,
            Biodiesel,
            Ethaonol
        }
        #endregion

        #region Properties
        //public string Fuel { get; set; }
        public EnumFuel Fuel { get; set; }
        #endregion

        #region Constructors
        public Airplane() : base() { }
        public Airplane(int vehicleId, string description, string model, EnumFuel fuel) : base(vehicleId, description, model)
        {
            Fuel = fuel;
            VehicleId = vehicleId;
            Description = description;
            Model = model;
        }
        #endregion

        #region Methods
        public void Fly()
        {
            
            Console.WriteLine($"Airplane: {Description}");
            
        }

        public void Register()
        {
            Console.WriteLine($"{VehicleId}, {Description}, {Model}, {Fuel} ");
        }

        //public override void Terminate()
        //{
        //}

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01_OOP_Interfaces_Vehicle.Interfaces;

namespace E01_OOP_Interfaces_Vehicle.Classes
{
    public class Car : Vehicle, ICar
    {
        #region Properties
        public string Color { get; set; }
        #endregion


        #region Constructor
        public Car() : base() { }
        public Car(int vehicleId, string description, string model, string color) : base(vehicleId, description, model)
        {
            Color = color;
            //como não estou acrescentando nada, o corpo pode fiar vazio.
            //VehicleId = vehicleId;
            //Description = description;
            //Model = model;
        }
        #endregion

        #region Methods
        public void Drive()
        {
            Console.WriteLine($"Car: {Description}");
        }

        public void Register()
        {
            Console.WriteLine($"{VehicleId}, {Description}, {Model}, {Color} ");
        }

        //public override void Terminate()
        //{
        //}
        #endregion
    }
}

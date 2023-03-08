using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01_OOP_Interfaces_Vehicle.Interfaces;

namespace E01_OOP_Interfaces_Vehicle.Classes
{
    public class Submarine : Vehicle, ISubmarine
    {
        #region Properties

        #endregion
        public bool Tripulado { get; set; }

        #region Constructors
        public Submarine() : base() { }
        public Submarine(int vehicleId, string description, string model, bool tripulado) : base(vehicleId, description, model)
        {
            Tripulado = tripulado;
        }
        #endregion
        public void Dive()
        {
            Console.WriteLine($"Submarine: {Description}");
        }

        public void Register()
        {
            Console.WriteLine($"{VehicleId}, {Description}, {Model}, {Tripulado} ");
        }

        //public override void Terminate()
        //{
        //}
    }
}

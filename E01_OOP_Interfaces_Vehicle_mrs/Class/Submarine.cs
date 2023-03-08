using E01_OOP_Interfaces_Vehicle.Interface;
using System;

namespace E01_OOP_Interfaces_Vehicle.Class
{

    public class Submarine : Vechicle, IVehicleWater
    {

        #region Properties
        public bool Crew { get; set; }
        #endregion

        #region Constructors
        public Submarine()
        {

            VehicleId = 0;
            Description = string.Empty;
            Model = string.Empty;
            Crew = true;

        }

        public Submarine(int vechicleId, string description, string model, bool crew)
        {

            VehicleId = vechicleId;
            Description = description;
            Model = model;
            Crew = crew;

        }
        #endregion

        #region Methods        
        public void Dive()
        {

            Console.WriteLine($"\nDive - {Description}");

        }
        #endregion

    }

}

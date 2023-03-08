using E01_OOP_Interfaces_Vehicle.Interface;
using System;

namespace E01_OOP_Interfaces_Vehicle.Class
{

    public class Vechicle : IVehicle
    {        

        #region Properties
        public int VehicleId { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }        
        #endregion        

        #region Methods
        public void Register(string message)
        {

            Console.WriteLine(message);

        }

        public void Terminate()
        {

            Console.WriteLine($"\nTerminate - {Description}");

        }
        #endregion

    }

}

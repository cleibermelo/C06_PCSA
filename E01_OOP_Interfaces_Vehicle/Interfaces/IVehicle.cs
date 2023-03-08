using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle.Interfaces
{
    public interface IVehicle
    {
        #region Properties
        int VehicleId { get; }
        string Description { get; }
        string Model { get; }
        #endregion

        #region Methods
        void Register();
        void Terminate();
        #endregion
    }
}

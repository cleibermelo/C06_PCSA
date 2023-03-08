using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E01_OOP_Interfaces_Vehicle.Classes.Airplane;

namespace E01_OOP_Interfaces_Vehicle.Interfaces
{
    public interface IAirplane
    {
        #region Properties
        //string Fuel { get; }
        #endregion

        void Fly();
    }
}

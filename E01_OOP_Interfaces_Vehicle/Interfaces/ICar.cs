using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle.Interfaces
{
    public interface ICar
    {
        #region Properties
        string Color { get; }
        #endregion

        void Drive();
    }
}

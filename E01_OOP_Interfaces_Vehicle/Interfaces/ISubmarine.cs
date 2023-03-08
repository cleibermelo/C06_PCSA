using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle.Interfaces
{
    public interface ISubmarine
    {
        #region Properties
        bool Tripulado { get; }
        #endregion

        void Dive();
    }
}

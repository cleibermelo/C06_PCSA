using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Collections_Car.Classes
{
    internal class InMemoryData
    {
        #region Properties
        public static List<Car> Cars { get; set; }
        #endregion

        #region Methods
        public static void Initialize()
        {
            Cars = GetStorageCar();
        }

        private static List<Car> GetStorageCar()
        {
            List<Car> carData = new List<Car>
            {

            };
            return carData;
        }
        #endregion
    }
}

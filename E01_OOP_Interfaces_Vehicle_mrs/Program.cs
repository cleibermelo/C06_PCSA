using D00_Utility;
using E01_OOP_Interfaces_Vehicle.Class;

namespace E01_OOP_Interfaces_Vehicle
{

    class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Airplane
            Airplane airplane = new Airplane(1, "Airplane", "Airplane model", Airplane.EnumFuel.Diesel);
            Utility.WriteTitle("Vehicle Air");

            airplane.Register($"Register - {airplane.VehicleId}, {airplane.Description}, {airplane.Model}, {airplane.Fuel}");
            airplane.Fly();
            airplane.Terminate();
            #endregion            

            #region Car
            Car car = new Car(1, "Car", "Car model", Car.EnumColor.Red);

            Utility.BlockSeparator("\n\n");
            Utility.WriteTitle("Vehicle Road");

            car.Register($"Register - {car.VehicleId}, {car.Description}, {car.Model}, {car.Color}");
            car.Drive();
            car.Terminate();
            #endregion            

            #region Submarine
            Submarine submarine = new Submarine(1, "Submarine", "Submarine model", true);

            Utility.BlockSeparator("\n\n");
            Utility.WriteTitle("Vehicle Water");

            submarine.Register($"Register - {submarine.VehicleId}, {submarine.Description}, {submarine.Model}, {submarine.Crew}");
            submarine.Dive();
            submarine.Terminate();
            #endregion

            Utility.TerminateConsole();

        }

    }

}

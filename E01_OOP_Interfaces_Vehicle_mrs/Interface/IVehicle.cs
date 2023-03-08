namespace E01_OOP_Interfaces_Vehicle.Interface
{

    interface IVehicle
    {

        #region Properties
        int VehicleId { get; }
        string Description { get; }
        string Model { get; }        
        #endregion

        #region Methods
        void Register(string message);
        void Terminate();
        #endregion

    }

}

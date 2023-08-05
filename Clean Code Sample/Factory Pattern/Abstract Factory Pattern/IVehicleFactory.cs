using System.ComponentModel;

namespace Clean_Code_Sample.Factory_Pattern.Abstract_Factory_Pattern
{
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}

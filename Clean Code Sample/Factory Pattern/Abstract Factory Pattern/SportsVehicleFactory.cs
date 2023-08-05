namespace Clean_Code_Sample.Factory_Pattern.Abstract_Factory_Pattern
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportBike();
        }
        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}

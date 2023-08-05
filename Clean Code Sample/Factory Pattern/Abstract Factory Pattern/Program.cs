namespace Clean_Code_Sample.Factory_Pattern.Abstract_Factory_Pattern
{
    public class Program
    {
        public static void Main()
        {
            // Fetch the Regular Bike and Car Details
            // Creating RegularVehicleFactory instance
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            //regularVehicleFactory.CreateBike() will create and return Regular Bike
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();
            //regularVehicleFactory.CreateCar() will create and return Regular Car
            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();
            // Fetch the Sports Bike and Car Details Created
            // Creating SportsVehicleFactory instance 
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            //sportsVehicleFactory.CreateBike() will create and return Sports Bike
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            //sportsVehicleFactory.CreateCar() will create and return Sports Car
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
            Console.ReadKey();
        }
    }
}

namespace SOLID.OpenClosed
{
    //GOOD SCENARIO
    //GOAL is Flexible Code
    public abstract class Vehicle
    {
        public abstract void Start();
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
    public class Helicopter : Vehicle
    {
        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
    public class Truck : Vehicle
    {
        public override void Start()
        {
            throw new NotImplementedException();
        }
    }

    public class VehicleEngineManager
    {
        public void Start(Vehicle vehicle)
        {
            vehicle.Start();
        }
    }

    //And now we can create a new vehicle type. for example Plane. "Open to extension"
    //We will not change the Start method of VehicleEngineManager class. because of, this method uses Vehicle type parameter.  "Closed to modification"
}

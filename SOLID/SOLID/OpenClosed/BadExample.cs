namespace SOLID.OpenClosed
{
    //Notice :  Codes must be open to extension, close to modification. 

    //BAD SCENARIO
    public class XCar
    {
        public void Start() { }
    }

    public class XHelicopter
    {
        public void Start() { }
    }

    public class EngineManager
    {
        public void StartEngine(XCar car)
        {
            car.Start();
        }

        public void StartEngine(XHelicopter helicopter)
        {
            helicopter.Start();
        }

        // or we can write this
        public void StartEngine(object engine)
        {
            if (engine is XCar)
            {

            }
            else if (engine is XHelicopter)
            {

            }
            //Important Point :  if we add a new type like Plane, EngineManager can not start Plane's engine. 
            //And now we have to add a new else if block for Plane class. 
        }
    }
}

namespace Clean_Code_Sample.OO_Class
{
    public class AbstractTestClass
    {
        public string Url { get; private set; }
        public string Name { get; private set; }

        private AbstractTestClass()
        {
            Console.WriteLine("initiated..");
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Helicopter());
            vehicles.Add(new Truck());

            foreach (var vehicle in vehicles)
            {
                vehicle.Accelerate();
            }
        }

        private AbstractTestClass(string name, string url) : this()
        {
            this.Url = url;
            this.Name = name;
        }

        public static AbstractTestClass Create(string name, string url)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentNullException(); }
            if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentNullException(); }

            return new AbstractTestClass(name, url);
        }

        public void Connect()
        {
            //this.Url;
        }
    }

    public abstract class Vehicle
    {
        public abstract void Accelerate();
    }

    public class Truck : Vehicle
    {
        public override void Accelerate()
        {
            throw new NotImplementedException();
        }
    }

    public class Helicopter : Vehicle
    {
        public override void Accelerate()
        {
            throw new NotImplementedException();
        }
    }
}

namespace Clean_Code_Sample.Factory_Pattern.Abstract_Factory_Pattern
{
    internal class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}

namespace SOLID.InterfaceSegregation
{
    //Single Responsibility and Interface Segregation

    public interface ISeller
    {
        void SaleToCustomer();
    }
    public interface ICreator
    {
        void CreateOrder();
    }
    public interface IReporter
    {
        void GetReports();
    }

    public class Vendor : ISeller, ICreator
    {
        public void CreateOrder()
        {
            Console.WriteLine("Order could be inserted.");
        }
        public void SaleToCustomer()
        {
            Console.WriteLine("Retail Sale informations could be inserted.");
        }
    }
    public class HeadOffice : ISeller, IReporter, ICreator
    {
        public void CreateOrder()
        {
            Console.WriteLine("Order could be inserted.");
        }
        public void GetReports()
        {
            Console.WriteLine("Report is preparing.");
        }
        public void SaleToCustomer()
        {
            Console.WriteLine("Retail Sale informations could be inserted.");
        }
    }
}

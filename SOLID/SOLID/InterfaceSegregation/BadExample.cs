namespace SOLID.InterfaceSegregation
{
    public interface IClient
    {
        void CreateOrder();
        void GetReports();
        void SaleToCustomer();
    }
    //Important : Dealer may not have permissions for getting reports but IClient inteface has GetReports function!! 
    public class Dealer : IClient
    {
        public void CreateOrder()
        {
            Console.WriteLine("Order could be inserted.");
        }
        public void GetReports()
        {
            throw new NotImplementedException();
        }
        public void SaleToCustomer()
        {
            Console.WriteLine("Retail Sale informations could be inserted.");
        }
    }

    public class Distributor : IClient
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

    //** We need to change our approaching. Look at Good Example 2 =>
}

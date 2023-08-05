namespace Clean_Code_Sample.Special_Case_Pattern
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Order placed ...");
        }
    }
    
    // in this special case scenario, we inherit and do nothing from there
    public class NullOrder : Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Do nothing ...");
        }
    }
}

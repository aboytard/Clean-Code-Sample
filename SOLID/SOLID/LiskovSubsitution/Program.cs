namespace SOLID.LiskovSubsitution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good Example Sample
            NewShape mySquare = new NewSquare(4);
            NewShape myRect = new NewRectangle(5, 4);

            List<NewShape> shapeList = new List<NewShape>() { mySquare, myRect };
            foreach (var item in shapeList)
            {
                Console.WriteLine(item.CalculateArea());
            }

            // ------------------------------------------------------

            //Another Good Example Sample
            Order o1 = new DealerOrder() { OrderDate = DateTime.UtcNow, };
            Order o2 = new DistributorOrder() { OrderDate = DateTime.UtcNow };
            Order o3 = new Order() { OrderDate = DateTime.UtcNow };
            Order o4 = new UserOrder() { OrderDate = DateTime.UtcNow.AddHours(6) };

            var orders = new List<Order>();
            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);
            orders.Add(o4);

            //There is no special case for any class. Every one runs perfectly. 
            foreach (var item in orders)
            {
                Console.WriteLine(item.CalculateEstimatedDeliveryDate());
            }

            Console.Read();
        }
    }
}

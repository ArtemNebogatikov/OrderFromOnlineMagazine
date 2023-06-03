using System;

namespace OrderFromOnlineMagazine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order<HomeDelivery,StructOrder> order = new Order<HomeDelivery,StructOrder>();
            var compliteorder = order.AddProductToOrder();
            foreach (var item in compliteorder)
            {
                Console.WriteLine("Товар в заказе {0}, {1}, {2}, {3}",item.Code, item.Name, item.Type, item.Price);
            }
            Console.ReadKey();
        
        }
    }
}

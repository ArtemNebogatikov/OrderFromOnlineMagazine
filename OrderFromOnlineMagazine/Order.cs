using System;
using System.Collections.Generic;

namespace OrderFromOnlineMagazine
{
    class Order<TDelivery,TStruct> 
        where TDelivery : Delivery
        where TStruct : StructOrder
    {
        public TDelivery Delivery;
        public TStruct StructOrder;

        public int Number;

        public string Description;
        public Product[] AddProductToOrder() 
        {
            StructOrder structOrder = new StructOrder();
            Product[] products = new Product[5];

            for (int i = 0; i < products.Length; i++)
            {
                products[i] = structOrder.AddProduct();
            }
            return products;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }
    class StructOrder
    {
        private decimal _sumPrice;
        public decimal SumPrice { get { return _sumPrice; } }
        public Product[] Products;
        /// <summary>
        /// Расчет суммы заказа
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public decimal CalculateOrder(Product[] products)
        {
            foreach(var product in Products)
            {
                _sumPrice += product.Price;
            }
            return _sumPrice;
        }
        /// <summary>
        /// Добавляем товар в заказ
        /// </summary>
        /// <returns></returns>
        public Product AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Введите тип");
            product.Type = Console.ReadLine();
            Console.WriteLine("Введите название");
            product.Name = Console.ReadLine();
            return product;
        }

    }
    /// <summary>
    /// Товар
    /// </summary>
    class Product
    {
        private int _code;
        private string _type;
        private string _name;
        private decimal _price;
        public string Name { get { return _name; } set { _name = value; } }
        public string Type { get { return _type;} set { _type = value; } }
        public int Code { get { return _code; } set { _code = value;} }
        public decimal Price { get { return _price; } set { _price = value; } }
        Random rand = new Random();
        public Product()
        {
            _code = rand.Next(50, 101);
            _type = Type;
            _name = Name;
            _price = (decimal)rand.Next(2, 100);
        }
        public Product(string Type, string Name)
        {
            _code = rand.Next(50, 101);
            _type = Type;
            _name = Name;
            _price = (decimal)rand.Next(2, 100);

        }

    }
}

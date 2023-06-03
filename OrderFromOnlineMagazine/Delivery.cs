using System;

namespace OrderFromOnlineMagazine
{
    abstract class Delivery
    {
        public string Address;
        public DateTime dateDate;
        public abstract void GoToPoint(string Address, DateTime dateTime);
    }
    /// <summary>
    /// Доставка на дом
    /// </summary>
    class HomeDelivery : Delivery
    {

        public override void GoToPoint(string Address, DateTime dateTime)
        {
            Console.WriteLine("Заказ будет доставлен в {0} по адресу {1}", dateDate.AddHours(1).ToString(), Address);
        }
    }
    /// <summary>
    /// Доставка в пункт выдачи
    /// </summary>
    class PickPointDelivery : Delivery
    {
        public override void GoToPoint(string Address, DateTime dateTime)
        {
            Console.WriteLine("Заказ передан для доставки в транспортную компанию по адресу {0} и будет доставлен в {1}", Address, dateDate.AddHours(1).ToString());
        }
    }
    /// <summary>
    /// Доставка в магазин
    /// </summary>
    class ShopDelivery : Delivery
    {

        public override void GoToPoint(string Address, DateTime dateTime)
        {
            Console.WriteLine("Заказ передан для доставки в магазин по адресу {0} и будет доставлен в {1}", Address, dateDate.AddHours(1).ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICP.Before
{
    // Изначально у нас есть интерфейс бизнеса, который иеет метод закупки товара
    public interface IBusinessBefore
    {
        void BuyProduct();

        // Расширение интерфеса
        void Deliver();
    }

    // Открывается первый бизнес маркет, реализующий интерфейс бизнеса 
    public class Market : IBusinessBefore
    {
        public void BuyProduct()
        {
            Console.WriteLine("Buying");
        }


        // Но при этом маркет не может доставлять товары.
        // Из-за этого может случиться исключение во время исполнения.
        public void Deliver()
        {
            throw new NotImplementedException();
        }
    }

    // Но тут открывается второй бизнес, который помимо закупки имеет метод доставки
    // Из-за этого поиходится расширять интерфейс
    public class Pizzeria : IBusinessBefore
    {
        public void BuyProduct()
        {
            Console.WriteLine("Buying");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering");
        }
    }


}

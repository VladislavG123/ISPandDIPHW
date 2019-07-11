using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICP.After
{
    // Для решение проблемы, лучше разделить на две части интерфейс

    public interface IProductBuying
    {
        void BuyProduct();
    }

    public interface IDelivering
    {
        void Deliver();
    }
    
    public class Market : IProductBuying
    {
        public void BuyProduct()
        {
            Console.WriteLine("Buying");
        }
    }
    
    public class Pizzeria : IProductBuying, IDelivering
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

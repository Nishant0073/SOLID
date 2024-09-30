using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    interface IWaiterInterface
    {
        void ServeFood();
        void TakeOrders();
    }
    interface ICookInterface
    {
        void CookFood();
        void DecideMenu();
    }


    //Waiter has only method which belongs to him 
    class Waiter : IWaiterInterface
    {
        public void ServeFood()
        {
            Console.WriteLine("Serving the food");
        }

        public void TakeOrders()
        {
            Console.WriteLine("Taking Orders"); 
        }
    }

    class Cook : ICookInterface
    {
        public void CookFood()
        {
            Console.WriteLine("Cooking food");
        }
        public void DecideMenu()
        {
            Console.WriteLine("Deciding Menu");
        }
    }
}

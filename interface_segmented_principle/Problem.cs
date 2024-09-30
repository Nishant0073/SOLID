using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    interface IRestaurantEmployee
    {
        void WashDishesh();
        void ServeFood();
        void CookFood();
    }


    //TIP: till C# 8.0 need to implement all method in interace in subclass but after 8.0 it is not nessesory to impelement all interace methods

    public class Waiter : IRestaurantEmployee
    {
        public void WashDishesh() {
            //not my job
            Console.WriteLine("Washing dishes"); 
        }

        public void ServeFood()
        {
            Console.WriteLine("Serving food");
        }
        public void CookFood() { 
            //not my job
            Console.WriteLine("Serving food");
        }
    }
}

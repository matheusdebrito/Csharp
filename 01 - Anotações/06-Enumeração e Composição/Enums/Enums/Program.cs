using System;
using Enums.Entities;
using Enums.Entities.Enums; //Importa o Enum

namespace Enums
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Converte do tipo OrderStatus para string
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Converte tipo string para tipo OrderStatus

            Console.WriteLine(os);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind_Practice.Models;

namespace Northwind_Practice.DataAccess
{
    public class OrderDataAccess
    {
        NorthwindContext context;

        public OrderDataAccess()
        {
            context = new NorthwindContext();
        }

        // first ques
        public void OrdersByCount()
        {
            var Query1 = from o in context.Orders
                         group o by o.CustomerId
                         into grp
                         select new { CustomerId = grp.Key, OrderCount = grp.Count() };

            foreach (var item in Query1)
            {
                Console.WriteLine($"customer ID: {item.CustomerId}");
                Console.WriteLine($"Total Orders: {item.OrderCount}");
                Console.WriteLine("==========================");
               
            }
        }

        //second ques

        public void OrderDetails()
        {
            var order_1 = from custom in context.Customers
                          join order in context.Orders on custom.CustomerId equals order.CustomerId
                          join order_D in context.OrderDetails on order.OrderId equals order_D.OrderId
                          select new
                          {
                              Customer = custom.CustomerId,
                              CustomerName = custom.ContactName,
                              Order = order.OrderId,
                              OrderPrice = order_D.UnitPrice,
                              OrderQuantity = order_D.Quantity,
                              productid = order_D.ProductId
                          };

            foreach (var item in order_1)
            {
                Console.WriteLine($"customer ID: {item.CustomerName}");
                Console.WriteLine($"Order ID: {item.Order}");
                Console.WriteLine($"Orders Price: {item.OrderPrice}");
                Console.WriteLine($"Orders Qunatity: {item.OrderQuantity}");
                Console.WriteLine($"product ID: {item.productid}");
                Console.WriteLine("==========================");
            }
        }


        //third ques
        public void OrderPrice()
        {
            var Query3 = from o in context.Orders
                         join d in context.OrderDetails
                         on o.OrderId equals d.OrderId
                         select d.Quantity * d.UnitPrice;


            foreach (var item in Query3)
            {
                Console.WriteLine($"{context.Orders}");
                Console.WriteLine($"price: {item}");
                // Console.WriteLine($"Orders ID: {item.}");
                Console.WriteLine("========================");
            }
        }

        //fourth question
        public void GetOrderbyID()
        {
            var Query_4 = from cust in context.Customers
                          join ord in context.Orders
                          on cust.CustomerId equals ord.CustomerId
                          select ord;

            foreach (var item in Query_4)
            {
                Console.WriteLine(item.OrderId.ToString(), item.OrderDetails, item.ShipCity, item.ShipName);
            }

        }

        //fifth question

        public void GetRejectedOrders()
        {
            var Query_5 = from cust in context.Customers
                          join order in context.Orders
                          join orderD in context.OrderDetails on Customer.customerID = Order.CustomerID
                          select GetOrderbyID;
            where (age> 10 && city='tokyo' && cityname ) 

                          on Orders.OrderId equals order.OrderId
                          select order;

            var Query_6 = from cust in context.Customers
                          from order in context.Orders
                          where cust.CustomerId = order.CustomerId
                          select order;
            
        }

    }   
}
    

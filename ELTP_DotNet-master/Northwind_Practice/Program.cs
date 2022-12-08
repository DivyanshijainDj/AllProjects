// See https://aka.ms/new-console-template for more information

using Northwind_Practice.DataAccess;
using Northwind_Practice.Models;
using System.Text.Json;


Console.WriteLine("northwind database");
Console.WriteLine();

OrderDataAccess OrderDataAccess = new OrderDataAccess();

//OrderDataAccess.OrdersByCount();
//OrderDataAccess.OrderDetails();
//OrderDataAccess.OrderPrice();

//method calling;

OrderDataAccess.GetOrderbyID();

Console.ReadLine();

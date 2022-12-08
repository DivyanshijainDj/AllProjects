// See https://aka.ms/new-console-template for more information
Console.WriteLine("fields");
Console.WriteLine();


Customer customer = new Customer(1);
customer.Orders.Add(new Order());

Console.WriteLine(customer.Orders.Count);

customer.Promote();
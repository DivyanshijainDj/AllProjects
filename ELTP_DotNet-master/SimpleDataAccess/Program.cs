using SimpleDataAccess.Models;
using SimpleDataAccess.DataAccess;


Console.WriteLine("USing ADO.NET");
try
{
    CategoryDbAccess categoryDbAccess = new CategoryDbAccess();
    ProductDbAccess productDbAccess = new ProductDbAccess();
    

    Console.WriteLine("Please enter type on which operation must perform:");
    Console.WriteLine("1. category");
    Console.WriteLine("2. product");
    var choice = Convert.ToInt32(Console.ReadLine());


    //for category
    if (choice == 1)
    {
        var categories = categoryDbAccess.GetRecords();
        PrintData(categories);

        Console.WriteLine();


        var cat = new Category()
        {

            CategoryId = 10005,
            CategoryName = "Healthcare (Infants)",
            BasePrice = 8000
        };

        categoryDbAccess.CreateRecord(cat);
        //categoryDbAccess.UpdateRecord(cat.CategoryId,cat);
        //categoryDbAccess.DeleteRecord(cat.CategoryId);

        categories = categoryDbAccess.GetRecords();
        PrintData(categories);
    }


    //for product
    if(choice ==2)
    {
        var p = new Product()
        {

            ProductUniqueId = 1111,
            ProductId = "pro-1234",
            ProductName="divyanshi",
            Description="developer",
            Manufacturer="udaipur",
            Price=123456789,
            CategoryId=2
        };

        

       
    }
    
}
catch (Exception ex)
{
    Console.WriteLine($"Error Occurred {ex.Message}");
}
Console.ReadLine();



static void PrintData(IEnumerable<Category> categories)
{
    foreach (var cat in categories)
    {
        Console.WriteLine($"{cat.CategoryId} {cat.CategoryName} {cat.BasePrice}");
    }
}

static void PrintDataInProducts(IEnumerable<Product> products)
{
    foreach (var pro in products)
    {
        Console.WriteLine($"{pro.ProductId} {pro.ProductUniqueId} {pro.ProductName} {pro.Description} {pro.Manufacturer} {pro.Price} {pro.CategoryId}");
    }
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Interfaces");
Console.WriteLine();

DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
dbMigrator.Migrate();
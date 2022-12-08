// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var dbMigrator = new DbMigrator(new Logger());

var logger = new Logger();

var installer = new Installer(logger);

dbMigrator.Migrate();

installer.Install();

//==========================nullable type============================

int? i = null;
i = 10;
i = 20;
Console.WriteLine(i);

string name = string.Empty;
Console.WriteLine("name: "+ name);
Console.WriteLine("==============");

//==================dynamic type===============================

dynamic k = 10;
var j = k + 10;

Console.WriteLine(j);
Console.WriteLine(k);

dynamic fname = "divyanshi";
dynamic lname = "jain";
var fullName = fname + lname;

Console.WriteLine(fullName);


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classes");
Console.WriteLine();
Console.WriteLine();

name input = new name();


input.fname = "divyanshi";
input.lname = "jain";

input.fullname();

public class name
    {
        public string fname;
        public string lname;

        public void fullname()
        {
            Console.WriteLine(fname + " " + lname);
        }


    }


        



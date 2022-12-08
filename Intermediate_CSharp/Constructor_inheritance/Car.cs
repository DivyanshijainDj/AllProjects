// See https://aka.ms/new-console-template for more information

public class Car : Vechile
{
    public Car(string RegistrationNumber)
        :base(RegistrationNumber)
    {
        Console.WriteLine("car initialized {0}", RegistrationNumber);
    }

}



  int num= Convert.ToInt32(Console.ReadLine());
    int denum = Convert.ToInt32(Console.ReadLine());;

try
{
    var result = num / denum;
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine("invalid"); 
}
finally
{
    Console.WriteLine("always there!!");
}


//var cal = new calculator();

/* public void division(int num1, int num2) {
         try {
            result = num1 / num2;
         } catch (DivideByZeroException e) {
            Console.WriteLine("Exception caught: {0}", e);
         } finally {
            Console.WriteLine("Result: {0}", result);
         }
      }

*/



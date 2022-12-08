
namespace ExtensionMethod
{

	static class NewMethodClass
	{
		public static void M4(this baseclass g)
		{
			Console.WriteLine("Method  M4");
		}

		public static void M5(this baseclass g, string str)
		{
			Console.WriteLine(str);
		}
	}

}



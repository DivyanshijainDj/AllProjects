// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lambda Expressions");
Console.WriteLine();



			List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9};

		
			var square = numbers.Select(x => x * x);

		
			Console.Write("Squares : ");
			foreach (var value in square)
			{
				Console.Write("{0} ", value);
	
			}

Console.WriteLine();
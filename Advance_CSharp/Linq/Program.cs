//int[] nums = new int[] { 0, 1, 2 ,3,4,5,6,7,8,9};


//var res = from a in nums 
//          where a < 3 
//          orderby a select a;


//foreach (int i in res)
//    Console.WriteLine(i);

//int oddNumbers = nums.Count(n => n % 2 == 1);
//Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);


using Linq;

var studentNames = Student.studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StandardID > 0)
                              .Select(s => s.StudentName);


foreach(var item in studentNames)
Console.WriteLine(item);

var studentsGroupByStandard = from s in Student.studentList
                              group s by s.StandardID into sg
                              orderby sg.Key
                              select new { sg.Key, sg };


foreach (var group in studentsGroupByStandard)
{
    Console.WriteLine("StandardID {0}:", group.Key);

    group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}
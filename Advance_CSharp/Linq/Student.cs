
namespace Linq;
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public int StandardID { get; set; }

    public static List<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "divyanshi", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "sanidhya",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "princee",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "rosh" , Age = 20, StandardID = 2 } ,
    new Student() { StudentID = 5, StudentName = "sahil" , Age = 21 }
};

  

}

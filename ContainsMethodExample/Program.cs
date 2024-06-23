// Contains Method in Linq
using ContainsMethodExample;

var studentList = new List<Student>()
{
    new Student { Id = 1, Name = "Osama", Age = 21 } ,
    new Student { Id = 2, Name = "Basem", Age = 34 } ,
    new Student { Id = 3, Name = "Abbas", Age = 27 } ,
};

var student = new Student { Id = 3, Name = "Abbas", Age = 28 };
bool result = studentList.Contains(student, new StudentComparer());
Console.WriteLine(result);

Console.ReadKey();

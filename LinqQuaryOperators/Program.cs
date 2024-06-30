using LinqQuaryOperators;
var students = Student.GetStudents();

// LINQ Extension Methods (Method Syntax)
students.Where(s => s.Age > 25).OrderByDescending(s => s.Age);

//Enumerable.Where(students, s => s.Age > 25);

// LINQ Query Operators (Query Syntax)
var data = (from s in students
            where s.Age > 25
            orderby s.Age descending
            select s).ToList();

foreach (var student in data)
    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");

Console.ReadKey();

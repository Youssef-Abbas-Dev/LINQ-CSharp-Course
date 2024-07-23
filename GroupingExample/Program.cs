// Grouping -> GroupBy(); ToLookup();
using GroupingExample;
var students = DataSource.GetStudents();


// Method Syntax (GroupBy)
var groupedStudent = students.GroupBy(s => s.Country);

// Query Syntax (GroupBy)
var groupedStudentQuery = from student in students
                          group student by student.Country;


// Method Syntax (ToLookup)
var groupedStudentToLookup = students.ToLookup(s => s.Country);

// GroupBy => deferred execution التنفيذ المؤجل
// ToLookup => immediate execution التفيذ السريع

foreach (var element in groupedStudent)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Students From {element.Key}");

    Console.ForegroundColor = ConsoleColor.Blue;
    foreach (var student in element) // Each group has an inner collection
    {
        Console.WriteLine($"Student Name: {student.Name}, Student Age: {student.Age}");
    }
    Console.WriteLine();
}


Console.ReadKey();

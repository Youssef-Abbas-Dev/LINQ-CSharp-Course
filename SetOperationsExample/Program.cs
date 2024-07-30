// Set Operations
//using SetOperationsExample;

/********** Distinct & DistinctBy *******/
//// Distinct

//var colors = new List<string> { "red", "blue", "yellow", "red", "blue", "black", "white" };
//var students = DataSource.GetStudents();

//var uniqueColors = colors.Distinct();
//foreach (var color in uniqueColors)
//    Console.WriteLine(color);

//// DistinctBy
//var uniqueStudents = students.DistinctBy(s => s.Name);
//foreach (var student in uniqueStudents)
//    Console.WriteLine(student.ToString());


/********** Except & ExceptBy ***********/
//// Except

//var colors = new List<string> { "red", "blue", "yellow", "black", "white" };
//var exceptResult = colors.Except(new List<string> { "blue", "yellow" });
//foreach (var color in exceptResult)
//    Console.WriteLine(color);

//// ExceptBy
//var students = DataSource.GetStudents();
//var studentsToExclude = DataSource.GetStudentsTwo().Select(s => s.Name);

//var exceptByResult = students.ExceptBy(studentsToExclude, s => s.Name);
//foreach (var student in exceptByResult)
//    Console.WriteLine(student.ToString());

/********** Intersect & IntersectBy *****/
//// Intersect
//var colors = new List<string> { "red", "blue", "yellow", "black", "white" };
//var colorsTwo = new List<string> { "blue", "yellow", "purple", "skyblue" };

//var intersectResult = colors.Intersect(colorsTwo);
//foreach (var color in intersectResult)
//    Console.WriteLine(color);

//// IntersectBy
//var students = DataSource.GetStudents();
//var studentToInclude = DataSource.GetStudentsTwo().Select(s => s.Name);

//var intersectByResult = students.IntersectBy(studentToInclude, s => s.Name);
//foreach (var student in intersectByResult)
//    Console.WriteLine(student.ToString());


/********** Union & UnionBy *************/
//// Union

//var colors = new List<string> { "red", "blue", "yellow", "black", "white" };
//var colorsTwo = new List<string> { "blue", "yellow", "purple", "skyblue" };

//var unionResult = colors.Union(colorsTwo);
//foreach (var color in unionResult)
//    Console.WriteLine(color);

//// UnionBy
//var students = DataSource.GetStudents();
//var studentsTwo = DataSource.GetStudentsTwo();

//var unionByResult = students.UnionBy(studentsTwo, s => s.Name);
//foreach (var student in unionByResult)
//    Console.WriteLine(student.ToString());

Console.ReadKey();

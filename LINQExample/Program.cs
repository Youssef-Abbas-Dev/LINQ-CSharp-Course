using LINQExample;
//Select();

var students = new List<Student>()
{
    new Student { Id = 1, Name = "Khaled", Age = 18, Country = "Egypt" },
    new Student { Id = 2, Name = "Ali", Age = 21, Country = "Iraq" },
    new Student { Id = 3, Name = "Ahmed", Age = 27, Country = "Egypt" },
    new Student { Id = 4, Name = "Saleh", Age = 31, Country = "Qatar" },
    new Student { Id = 5, Name = "Basem", Age = 35, Country = "Iraq" },
    new Student { Id = 6, Name = "Rami", Age = 19, Country = "Lebanon" },
    new Student { Id = 7, Name = "Osama", Age = 44, Country = "Egypt" },
};

//students.Sum(s => s.Id);

List<User> users = students.Select(student => new User
{
    Username = student.Name,
    UserCountry = student.Country,
    UserPhoto = "default-image.png"
}).ToList();


foreach (var user in users)
    Console.WriteLine($"{user.Username}, {user.UserCountry}, {user.UserPhoto}");


Console.ReadKey();
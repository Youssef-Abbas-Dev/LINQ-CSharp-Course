namespace LinqQuaryOperators
{
    public class Student
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int Age { get; set; }
        public required string Country { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
              new Student { Id = 1, Age = 18, Name = "Hasan", Country = "Egypt" },
              new Student { Id = 2, Age = 21, Name = "Salah", Country = "Iraq" },
              new Student { Id = 3, Age = 27, Name = "Ahmed", Country = "Egypt" },
              new Student { Id = 4, Age = 31, Name = "Saleh", Country = "Qatar" },
              new Student { Id = 5, Age = 35, Name = "Basem", Country = "Iraq" },
              new Student { Id = 6, Age = 19, Name = "Ramii", Country = "Lebanon" },
              new Student { Id = 7, Age = 44, Name = "Osama", Country = "Egypt" },
              new Student { Id = 8, Age = 34, Name = "Abbas", Country = "Yemen" },
            };
        }
    }
}

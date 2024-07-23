namespace GroupingExample
{
    public class DataSource
    {
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Age = 18, Name = "Khaled", Country = "Egypt" },
                new Student { Id = 2, Age = 21, Name = "Ali", Country = "Iraq" },
                new Student { Id = 3, Age = 27, Name = "Ahmed", Country = "Egypt" },
                new Student { Id = 4, Age = 31, Name = "Saleh", Country = "Qatar" },
                new Student { Id = 5, Age = 35, Name = "Basem", Country = "Iraq" },
                new Student { Id = 6, Age = 19, Name = "Rami", Country = "Lebanon" },
                new Student { Id = 7, Age = 44, Name = "Osama", Country = "Egypt" },
                new Student { Id = 8, Age = 25, Name = "Mazen", Country = "Egypt" },
                new Student { Id = 9, Age = 32, Name = "Salem", Country = "Iraq" },
                new Student { Id = 10, Age = 24, Name = "Sara", Country = "Lebanon" },
                new Student { Id = 11, Age = 27, Name = "Fatima", Country = "Iraq" },
                new Student { Id = 12, Age = 32, Name = "Maryam", Country = "Egypt" },
                new Student { Id = 13, Age = 28, Name = "Jasem", Country = "Qatar" },
                new Student { Id = 14, Age = 19, Name = "Nawal", Country = "Lebanon" },
                new Student { Id = 15, Age = 31, Name = "Warda", Country = "Lebanon" },
            };
        }
    }
}

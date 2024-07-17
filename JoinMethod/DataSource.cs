namespace JoinMethod
{
    public class DataSource
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, AuthorId = 101, Price = 15.77, Title = "Black Swan" },
                new Book { Id = 2, AuthorId = 101, Price = 10.99, Title = "Skin in The Game" },
                new Book { Id = 3, AuthorId = 101, Price = 11.99, Title = "Fooled by Randomness" },
                new Book { Id = 4, AuthorId = 102, Price = 10.55, Title = "The Alchemist" },
                new Book { Id = 5, AuthorId = 102, Price = 11.66, Title = "Maktub" },
                new Book { Id = 6, AuthorId = 102, Price = 14.99, Title = "Eleven Minutes" },
                new Book { Id = 7, AuthorId = 103, Price = 17.99, Title = "The Forty Rules of Love" },
            };
        }

        public static IEnumerable<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author { Id = 101, FullName = "Nassim Taleb", Country = "Lebanon" },
                new Author { Id = 102, FullName = "Paulo Coelho", Country = "Brazil" },
                new Author { Id = 103, FullName = "Elif Shafak", Country = "Turkey" },
            };
        }
    }
}

// Join();
using JoinMethod;

IEnumerable<Book> books = DataSource.GetBooks();
IEnumerable<Author> authors = DataSource.GetAuthors();

Console.WriteLine("-----Join-----");

// Method Syntax
IEnumerable<BookWithAuthor> booksWithAuthor = books.Join( // outer collection
     authors, // inner collection
     book => book.AuthorId, // outer key selector
     author => author.Id, // inner key selector
     (book, author) => new BookWithAuthor // result selector
     {
         BookId = book.Id,
         BookTitle = book.Title,
         BookPrice = book.Price,
         BookAuthor = author.FullName,
     });


// Query Syntax
IEnumerable<BookWithAuthor> booksWithAuthorQuery = from book in books // outer collection
                                                   join author in authors // inner collection
                                                   on book.AuthorId equals author.Id  // key selectors
                                                   select new BookWithAuthor // result selector
                                                   {
                                                       BookId = book.Id,
                                                       BookTitle = book.Title,
                                                       BookPrice = book.Price,
                                                       BookAuthor = author.FullName,
                                                   };


foreach (var bookWithAuthor in booksWithAuthorQuery)
    Console.WriteLine(bookWithAuthor.ToString());


Console.WriteLine("-----Group Join-----");

// Method Syntax
IEnumerable<BookWithAuthorGroupJoin> booksWithAuthorGroupJoin = books.GroupJoin( // outer collection
     authors, // inner collection
     book => book.AuthorId, // outer key selector
     author => author.Id, // inner key selector
     (book, authorCollection) => new BookWithAuthorGroupJoin // result selector
     {
         BookId = book.Id,
         BookTitle = book.Title,
         BookPrice = book.Price,
         Authors = authorCollection.ToList(),
     });


// Query Syntax
IEnumerable<BookWithAuthorGroupJoin> booksWithAuthorGroupJoinQuery = from book in books // outer collection
                                                                     join author in authors // inner collection
                                                                     on book.AuthorId equals author.Id  // key selectors
                                                                     into authorCollection
                                                                     select new BookWithAuthorGroupJoin // result selector
                                                                     {
                                                                         BookId = book.Id,
                                                                         BookTitle = book.Title,
                                                                         BookPrice = book.Price,
                                                                         Authors = authorCollection.ToList()
                                                                     };


foreach (var item in booksWithAuthorGroupJoinQuery)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Book Title: {item.BookTitle}, Book Price: ${item.BookPrice}");
    foreach (var author in item.Authors)
    {
        Console.WriteLine($"Author FullName: {author.FullName}, Author Country: {author.Country}");
    }
    Console.WriteLine("---");
}



Console.ReadKey();

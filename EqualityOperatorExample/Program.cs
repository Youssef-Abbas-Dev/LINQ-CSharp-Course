// LINQ Equality Operators: SequenceEqual
using EqualityOperatorExample;

//var letters = new List<char> { 'A', 'B', 'C', 'D' };
//var lettersTwo = new List<char> { 'A', 'B', 'C', 'D' };

//bool isEqual = letters.SequenceEqual(lettersTwo);
//Console.WriteLine(isEqual);

var products = new List<Product>()
{
    new Product { Title = "Book", Price = 10.99 },
    new Product { Title = "Pen", Price = 2.99 },
    new Product { Title = "Laptop", Price = 400.99 },
};

var productsTwo = new List<Product>()
{
    new Product { Title = "Book", Price = 10.99 },
    new Product { Title = "Pen", Price = 2.99 },
    new Product { Title = "Laptop", Price = 400.99 },
};

bool isProductsEqual = products.SequenceEqual(productsTwo, new ProductComparer());
Console.WriteLine(isProductsEqual);


Console.ReadKey();

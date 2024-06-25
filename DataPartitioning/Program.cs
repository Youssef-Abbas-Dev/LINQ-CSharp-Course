// Data Partitioning with Linq
// Skip(), SkipWhile(), SkipLast()
// Take(), TakeWhile(), TakeLast()
// Chunk()
using DataPartitioning;

var articles = Article.FetchArticles();
var pagination = new Pagination<Article>(5);

var data = pagination.Paginate(articles);

foreach (var article in data)
    Console.WriteLine($"ID: {article.Id}, TITLE: {article.Title}, DESCRIPTION: {article.Description}");




//var data = articles.Chunk(10).ToList();
//Console.WriteLine($"{data.Count()} Chunks\n");

//for (int i = 0; i < data.Count(); i++)
//{
//    Console.WriteLine($"Chunk: {i + 1}");
//    foreach (var article in data[i])
//        Console.WriteLine($"ID: {article.Id}, TITLE: {article.Title}, DESCRIPTION: {article.Description}");
//}


Console.ReadKey();

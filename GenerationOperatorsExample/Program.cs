// Generation Operators

// Empty
//var emptyCollection = Enumerable.Empty<int>();
//Console.WriteLine(emptyCollection.Count());

// Range
//var rangeCollection = Enumerable.Range(5, 10);
//foreach (var range in rangeCollection)
//    Console.WriteLine(range);

// Repeat
var repeatCollection = Enumerable.Repeat<string>("Hi", 10);
foreach (var item in repeatCollection)
    Console.WriteLine(item);

Console.ReadKey();

// Aggregate Methods in Linq
using AggregateMethodsExample;

var customAggregate = new CustomAggregate();

var prices = new int[] { 10, 20, 30, 40, 50 };

// Aggregate();
int totalAmount = prices.Aggregate(0, (sum, currentValue) => sum + currentValue);

Console.WriteLine(totalAmount);

//// Count();
//int count = prices.Count();
//Console.WriteLine(count);

//// LongCount();
//long longCount = prices.LongCount();
//Console.WriteLine(longCount);

// Min();
//int min = prices.Min();
//Console.WriteLine(min);
//Console.WriteLine(customAggregate.Min(prices));

// Max();
//int max = prices.Max();
//Console.WriteLine(max);
//Console.WriteLine(customAggregate.Max(prices));

// Average();
//double average = prices.Average();
//Console.WriteLine(average);
//Console.WriteLine(customAggregate.Average(prices));

// Sum();
//int sum = prices.Sum();
//Console.WriteLine(sum);
//Console.WriteLine(customAggregate.Sum(prices));

Console.ReadKey();

// SelectMany();
using SelectManyExample;

var countries = new List<Country>()
{
    new Country { Name = "Turkey", Cities = new() { "Istanbul", "Trabzon" } },
    new Country { Name = "Iraq", Cities = new() { "Baghdad", "Arbil" } },
    new Country { Name = "UAE", Cities= new() { "Abo Dhabi", "Dubai" }}
};


var result = countries.SelectMany(
    country => country.Cities,
    (country, city) => new CountryDto { CountryName = country.Name, CityName = city }
   );

foreach (var item in result)
    Console.WriteLine($"{item.CountryName} -> {item.CityName}");

Console.WriteLine("-----------------------------------------------------");

var colors = new List<string>() { "Red", "Green", "Blue" };
var colorsPalette = new List<string>() { "Light", "Medium", "Dark" };

var allColors = colors.SelectMany(
    color => colorsPalette,
    (color, palette) => $"{palette} {color}"
);

foreach (var color in allColors)
    Console.WriteLine(color);

Console.WriteLine("-----------------------------------------------------");

// Zip() -> Merge between 2 Collections

var columns = new List<char>() { 'A', 'B', 'C', 'D' };
var rows = new List<int>() { 1, 2, 3, 4 };

var items = columns.Zip(rows, (column, row) => $"{column}{row}");
foreach (var item in items)
    Console.WriteLine(item);

Console.ReadKey();

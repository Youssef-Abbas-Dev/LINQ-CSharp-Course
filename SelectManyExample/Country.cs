namespace SelectManyExample
{
    public class Country
    {
        public required string Name { get; set; }
        public required List<string> Cities { get; set; }
    }

    public class CountryDto
    {
        public required string CountryName { get; set; }
        public required string CityName { get; set; }
    }
}

using System.Diagnostics.CodeAnalysis;

namespace EqualityOperatorExample
{
    public class Product
    {
        public required string Title { get; set; }
        public required double Price { get; set; }
    }

    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? productOne, Product? productTwo)
        {
            if (productOne == null || productTwo == null) return false;

            if (productOne.Title == productTwo.Title && productOne.Price == productTwo.Price)
                return true;

            return false;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return obj.GetHashCode();
        }
    }
}

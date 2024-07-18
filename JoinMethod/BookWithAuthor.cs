namespace JoinMethod
{
    public class BookWithAuthor
    {
        public required int BookId { get; set; }
        public required string BookTitle { get; set; }
        public required string BookAuthor { get; set; }
        public required double BookPrice { get; set; }

        public override string ToString()
        {
            return $"BookId: {BookId}, Title: {BookTitle}, Author: {BookAuthor}, Price: ${BookPrice}";
        }
    }
}

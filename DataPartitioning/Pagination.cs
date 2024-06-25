namespace DataPartitioning
{
    public class Pagination<T> where T : class
    {
        private readonly int _dataPerPage;
        public Pagination(int dataPerPage)
        {
            _dataPerPage = dataPerPage;
        }

        public IEnumerable<T> Paginate(IEnumerable<T> collection)
        {
            var pageNumber = GetPageNumber();

            Console.WriteLine($"{typeof(T).Name}s For Page Number {pageNumber}");
            var data = collection
              .Skip(_dataPerPage * (pageNumber - 1))
              .Take(_dataPerPage);

            return data;
        }

        private int GetPageNumber()
        {
            Console.Write("Please enter page number: ");
            bool validPageNumber = int.TryParse(Console.ReadLine(), out int pageNumber);
            if (validPageNumber)
                return pageNumber;

            return 1;
        }
    }
}

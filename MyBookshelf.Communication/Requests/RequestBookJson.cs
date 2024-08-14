using MyBookshelf.Communication.Enums;

namespace MyBookshelf.Communication.Requests
{
    public class RequestBookJson
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public BookGenre Genre { get; set; }
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal StockQuantity { get; set; }
    }
}

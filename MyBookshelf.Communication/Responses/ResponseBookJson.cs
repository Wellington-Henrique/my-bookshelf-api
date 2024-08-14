using MyBookshelf.Communication.Enums;

namespace MyBookshelf.Communication.Responses
{
    public class ResponseBookJson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public decimal StockQuantity { get; set; }
    }
}

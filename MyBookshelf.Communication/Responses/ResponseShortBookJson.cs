using MyBookshelf.Communication.Enums;

namespace MyBookshelf.Communication.Responses
{
    public class ResponseShortBookJson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
    }
}

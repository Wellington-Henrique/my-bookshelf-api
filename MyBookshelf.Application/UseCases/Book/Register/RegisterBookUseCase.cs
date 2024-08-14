using MyBookshelf.Communication.Requests;
using MyBookshelf.Communication.Responses;

namespace MyBookshelf.Application.UseCases.Book.Register
{
    public class RegisterBookUseCase
    {
        public ResponseBookJson Execute(RequestBookJson request)
        {
            return new ResponseBookJson
            {
                Id = 1,
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Price = request.Price,
                StockQuantity = request.StockQuantity
            };
        }
    }
}

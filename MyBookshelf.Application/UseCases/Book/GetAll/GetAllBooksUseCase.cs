using MyBookshelf.Communication.Enums;
using MyBookshelf.Communication.Responses;

namespace MyBookshelf.Application.UseCases.Book.GetAll
{
    public class GetAllBooksUseCase
    {
        public ResponseAllBooksJson Execute()
        {
            return new ResponseAllBooksJson
            {
                Books = new List<ResponseShortBookJson>
                {
                    new ResponseShortBookJson
                    {
                        Id = 1,
                        Title = "O senhor dos anéis",
                        Genre = BookGenre.Fiction
                    }
                }
            };
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MyBookshelf.Application.UseCases.Book.Delete;
using MyBookshelf.Application.UseCases.Book.GetAll;
using MyBookshelf.Application.UseCases.Book.Register;
using MyBookshelf.Application.UseCases.Book.Update;
using MyBookshelf.Communication.Requests;
using MyBookshelf.Communication.Responses;

namespace MyBookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseBookJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestBookJson request)
        {
            var response = new RegisterBookUseCase().Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllBooksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new GetAllBooksUseCase().Execute();

            if (response.Books.Any())
                return Ok(response);

            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseBookJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestBookJson request)
        {
            new UpdateBookUseCase().Execute(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            new DeleteBookUseCase().Execute(id);

            return NoContent();
        }
    }
}

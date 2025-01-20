using Microsoft.AspNetCore.Mvc;

namespace Store.Nasser_Library.Controllers
{
    [ApiController]
    [Route("Books")]
    public class BookController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBooks")]
        public IEnumerable<Book> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Book
            {
                BookId = index,
                BookName = $"Book {index}",
                Price = Random.Shared.Next(10, 100),
                Quantity = Random.Shared.Next(1, 20),
            })
            .ToArray();
        }
    }
}

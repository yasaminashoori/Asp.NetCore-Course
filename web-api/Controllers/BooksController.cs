using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Repository;

namespace web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _booksRepository;
        private readonly ILogger<BooksController> _logger;

        public BooksController(
            IBookRepository bookRepository,
            ILogger<BooksController> logger)
        {
            _booksRepository = bookRepository;
            _logger = logger;
        }

        //Route: /api/Books
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _booksRepository.GetAllBooks();
            return Ok(books);
        }

    }
}

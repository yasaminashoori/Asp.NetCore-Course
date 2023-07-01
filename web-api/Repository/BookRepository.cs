using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api.Data;
using web_api.Models;

namespace web_api.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<BookDetailsDto>> GetAllBooks()
        {
            var books = await _context.Books.Select(x => new BookDetailsDto()
            {
                Id = x.Id,
                Amount = x.Amount,
                Description = x.Description,
                Title = x.Title
            }).ToListAsync();
            return books;
        }

        public async Task<BookDetailsDto> GetBookDetailsById(int id)
        {
            var book = await _context.Books.Where(x => x.Id == id)
                                    .Select(x => new BookDetailsDto()
                                    {
                                        Id = x.Id,
                                        Amount = x.Amount,
                                        Description = x.Description,
                                        Title = x.Title
                                    }).FirstOrDefaultAsync();
            return book;
        }
    }
}

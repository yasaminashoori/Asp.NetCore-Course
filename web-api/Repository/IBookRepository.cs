using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using web_api.Models;

namespace web_api.Repository
{
    public interface IBookRepository
    {
        Task<List<BookDetailsDto>> GetAllBooks();

        Task<BookDetailsDto> GetBookDetailsById(int id);
    }
}

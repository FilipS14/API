using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using DataBase.Repositories;
using DataBase.Entities;

namespace Core.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<BookModel>> GetAllBooksAsync()
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return books.Select(book => MapBookToModel(book));
        }

        public async Task<BookModel> GetBookByIdAsync(int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            return MapBookToModel(book);
        }

        private BookModel MapBookToModel(Book book)
        {
            if (book == null)
                return null;

            return new BookModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                AuthorId = book.AuthorID
            };
        }
    }
}

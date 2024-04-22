using Core.Models;
using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int id);

    }
}
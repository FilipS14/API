using Core.Models;
using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorModel>> GetAllAuthorsAsync();
        Task<AuthorModel> GetAuthorByIdAsync(int id);
        Task<IEnumerable<AuthorModel>> GetAuthorsWithBooksAsync();

    }
}
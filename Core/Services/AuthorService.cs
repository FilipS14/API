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
    public class AuthorService : IAuthorService
    {
        private  IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<IEnumerable<AuthorModel>> GetAllAuthorsAsync()
        {
            var authors = await _authorRepository.GetAllAuthorsAsync();
            return authors.Select(author => MapAuthorToModel(author));
        }

        public async Task<AuthorModel> GetAuthorByIdAsync(int id)
        {
            var author = await _authorRepository.GetAuthorByIdAsync(id);
            return MapAuthorToModel(author);
        }

        public async Task<IEnumerable<AuthorModel>> GetAuthorsWithBooksAsync()
        {
            var authors = await _authorRepository.GetAuthorsWithBooksAsync();
            return authors.Select(author => MapAuthorToModel(author));
        }

        private AuthorModel MapAuthorToModel(Author author)
        {
            if (author == null)
                return null;

            return new AuthorModel { Id = author.Id, Name = author.Name, SecondName = author.SecondName, };
        }
    }
}

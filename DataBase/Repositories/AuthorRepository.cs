using DataBase.Entities;
using DataBase.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class AuthorRepository : BaseRepository, IAuthorRepository
    {
        public AuthorRepository(ProjectDbContext context) : base(context)
        {
        }
        public void Add(Author autor)
        {
            _db.Autori.Add(autor);
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await _db.Autori.ToListAsync();
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await _db.Autori.FindAsync(id);
        }

        public async Task<IEnumerable<Author>> GetAuthorsWithBooksAsync()
        {
            return await _db.Autori.Include(author => author.Books).ToListAsync();
        }
    }
}

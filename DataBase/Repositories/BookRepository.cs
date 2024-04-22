using DataBase.Entities;
using DataBase.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataBase.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {

        public BookRepository(ProjectDbContext context) : base(context)
        {
        }

        public void Add(Book carte)
        {
            _db.Carti.Add(carte);
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _db.Carti.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _db.Carti.FindAsync(id);
        }

    }
}

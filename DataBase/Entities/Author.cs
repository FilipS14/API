using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class Author : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
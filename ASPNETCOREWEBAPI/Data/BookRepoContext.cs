using ASPNETCOREWEBAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ASPNETCOREWEBAPI.Data
{
    public class BookRepoContext : DbContext
    {
        public BookRepoContext(DbContextOptions<BookRepoContext> options):base(options) 
        {


        }

        public DbSet<Book> Books { get; set; }

    }


}

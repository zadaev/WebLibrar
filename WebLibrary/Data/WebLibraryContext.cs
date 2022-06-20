using Microsoft.EntityFrameworkCore;
using WebLibrary.Data.Models;

namespace WebLibrary.Data
{
    public class WebLibraryContext : DbContext
    {
        public WebLibraryContext(DbContextOptions<WebLibraryContext> option)
            : base(option)
        {

        }

        public DbSet<Librarian> Librarian { get; set; } = null!;
        public DbSet<Reader> Reader { get; set; } = null!;
        public DbSet<Book> Book { get; set; } = null!;
        public DbSet<BookRent> BookRents { get; set; } = null!;
    }
}

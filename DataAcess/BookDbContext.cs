using Microsoft.EntityFrameworkCore;

namespace DataAcess
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookDetail> Books { get; set; }
    }
}

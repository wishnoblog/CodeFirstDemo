using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// 書籍資料
        /// </summary>
        public DbSet<Book> Books { get; set; }
    }
}

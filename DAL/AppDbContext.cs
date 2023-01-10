using Microsoft.EntityFrameworkCore;

namespace bookshop.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }
    }
}

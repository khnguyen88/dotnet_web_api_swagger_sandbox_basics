using Microsoft.EntityFrameworkCore;

namespace WebAppSandbox01.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoItems> TodoItems { get; set; } 
    }
}

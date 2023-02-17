using Microsoft.EntityFrameworkCore;
using TESTESRest.Services;

namespace TESTESRest.Model
{
    public class MySqlContext: DbContext
    {
        public MySqlContext()
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options): base(options)
        { 
        
        }

        public DbSet<Person> People { get; set; }
    }
}

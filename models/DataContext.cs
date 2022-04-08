using Microsoft.EntityFrameworkCore;

namespace TEST_dotnet.models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Character> Characters{get;set;}
        
    }
}
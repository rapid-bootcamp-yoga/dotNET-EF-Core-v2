using Microsoft.EntityFrameworkCore;

namespace dotNetEFCore_v2.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();

    }
}

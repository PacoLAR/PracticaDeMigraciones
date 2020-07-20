using Microsoft.EntityFrameworkCore;

namespace Dragons.Models{
    
    public class DragonDbContext: DbContext
    {

        public DragonDbContext(DbContextOptions<DragonDbContext> options)
        : base(options){ }
        public DbSet<Dragon> Dragons {get;set;}
        
    }
}
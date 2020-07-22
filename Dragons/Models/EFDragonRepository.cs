using System.Linq;

namespace Dragons.Models
{
    public class EFDragonRepository:IDragonRepository
    {
         private DragonDbContext context;
        public EFDragonRepository(DragonDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Dragon> Dragons {get {
            return context.Dragons;
        }}
    }
}
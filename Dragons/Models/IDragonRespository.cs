using System.Linq;

namespace Dragons.Models
{
    public interface IDragonRepository
    {
        IQueryable<Dragon> Dragons  {get;}
    }
}
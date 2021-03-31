using System.Linq;

namespace SportsGoods.Models
{
    public interface IStoreRepository
    {
        
            IQueryable<Product> Products { get; }
        
    }

}
   
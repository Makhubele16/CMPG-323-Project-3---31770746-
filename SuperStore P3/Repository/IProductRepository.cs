using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetMostRecentProduct();
    }
}

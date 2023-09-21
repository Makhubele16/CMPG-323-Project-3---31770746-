using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrdersRepository : IGenericRepository<Order>
    {
        Order GetMostRecentOrder();
    }

}

using EcoPower_Logistics.Repository;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderDetailsRepository : IGenericRepository<OrderDetail>
    {
        OrderDetail GetMostRecentOrderDetail();
    }
}



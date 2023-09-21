using Data;
using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrdersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentOrder()
        {
            return _context.Orders.OrderByDescending(Order => Order.OrderId).FirstOrDefault();
        }
    }
}


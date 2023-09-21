using Data;
using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetMostRecentOrderDetail()
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetMostRecentOrderId()
        {
            return _context.OrderDetails.OrderByDescending(OrderDetail => OrderDetail.OrderDetailsId).FirstOrDefault();
        }
    }
}


using Data;
using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepository : GenericRepository<Customer>, ICustomersRepository
    {
        public CustomersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(Customer => Customer.CustomerId).FirstOrDefault();
        }
    }

}

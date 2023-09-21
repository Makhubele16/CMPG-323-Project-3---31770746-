using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomersRepository : IGenericRepository<Customer>
    {
        Customer GetMostRecentCustomer();
    }
}



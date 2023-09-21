using Data;
using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        public Product GetMostRecentProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetMostRecentProducts()
        {
            return _context.Products.OrderByDescending(Product => Product.ProductId).FirstOrDefault();
        }
    }
}


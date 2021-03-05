using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Models;
using Supermarket.Entites;
using System;
namespace Supermarket.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductEntity AddProduct(Product domain)
        {
            if (domain == null) throw new ArgumentNullException(nameof(domain));

            //to DB

            return null;
        }
    }
}

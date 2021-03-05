using Supermarket.Domain.Models;
using Supermarket.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Data.Repositories.Interfases
{
    public interface IProductRepository
    {
        ProductEntity AddProduct(Product domain);
    }
}

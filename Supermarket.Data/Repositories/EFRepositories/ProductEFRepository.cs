using Supermarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Data.Repositories.EFRepositories
{
    public class ProductEFRepository
    {
        public Product Create(Product model)
        {
            using (var context = new SupermarketContext("Default"))
            {
                var department = new Product()
                {
                    Name = "alcohol"
                };
            }

            return model;
        }
    }
}

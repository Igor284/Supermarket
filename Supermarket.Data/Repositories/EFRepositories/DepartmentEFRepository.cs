using Supermarket.Domain.Models;
using SupermarketDomainDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Data.Repositories
{
    public class DepartmentEFRepository
    {
        public Department Create(Department model)
        {
            using (var context = new SupermarketContext("Supermarket"))
            {
                var department = new Worker()
                {
                    Name = "alcohol department"
                };
            }

            return model;
        }
    }
}

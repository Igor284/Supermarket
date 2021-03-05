using System;
using Supermarket.Data.Repositories.Interfases;
using Supermarket.Entites;
using SupermarketDomainDtos;

namespace Supermarket.Data.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public DepartmentEntity AddDepartment(Department domain)
        {
            if (domain == null) throw new ArgumentNullException(nameof(domain));

            //to DB

            return null;
        }
    }
}

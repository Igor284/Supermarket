using Supermarket.Entites;
using SupermarketDomainDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Data.Repositories.Interfases
{
    public interface IDepartmentRepository
    {
        DepartmentEntity AddDepartment(Department domain);
    }
}

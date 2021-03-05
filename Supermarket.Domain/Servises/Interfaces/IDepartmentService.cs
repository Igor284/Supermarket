using Supermarket.Models;
using SupermarketDomainDtos;
namespace Supermarket.Domain.Servises.Interfaces
{
    public interface IDepartmentService
    {
        Department AddDepartment(DepartmentModel model);
    }
}

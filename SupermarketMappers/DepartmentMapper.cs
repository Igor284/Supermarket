using Supermarket.Entites;
using Supermarket.Models;
using SupermarketDomainDtos;

namespace SupermarketMappers
{
    public static class DepartmentMapper 
    {
        public static Department ToDomain(this DepartmentModel model)
        {
            return new Department
            {
                Name = model.Name
            };
        }

        public static Department ToDomain(this DepartmentEntity entity)
        {
            return new Department
            {
                Name = entity.Name
            };
        }


        public static DepartmentEntity ToEntity(this Department domain)
        {
            return new DepartmentEntity
            {
                Name = domain.Name
            };
        }

        public static DepartmentModel ToModel(this Department domain)
        {
            return new DepartmentModel
            {
                Name = domain.Name
            };
        }
    }
}

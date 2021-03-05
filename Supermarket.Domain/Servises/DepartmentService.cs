using System;
using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Servises.Interfaces;
using Supermarket.Models;
using SupermarketDomainDtos;
using SupermarketMappers;

namespace Supermarket.Domain.Servises
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public Department AddDepartment(DepartmentModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var domain = model.ToDomain();

            //Do some logic

           var entity = _repository.AddDepartment(domain);

           return entity.ToDomain();
        }
    }
}

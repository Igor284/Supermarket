using System;
using Supermarket.Domain.Servises;
using Supermarket.Domain.Servises.Interfaces;
using Supermarket.Models;
using SupermarketMappers;

namespace Supermarket.Controllers
{
    public class DepartmentController 
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }


        public DepartmentModel AddDepartment(DepartmentModel model)
        {
            if(model == null) throw new ArgumentNullException();

            if (model.Name.Length > 50) return null; //возвращаем предполагаемый тип ответа в данной ситуации

            var domain = _service.AddDepartment(model);
            
            return domain.ToModel();
        }
    }
}

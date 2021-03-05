using Supermarket.Domain.Servises;
using Supermarket.Domain.Servises.Interfaces;
using Supermarket.Models;
using SupermarketMappers;
using System;
namespace Supermarket.Controllers
{
    public class WorkerController 
    {
        private readonly IWorkerService _service;

        public WorkerController(IWorkerService service)
        {
            _service = service;
        }


        public WorkerModel AddWorker(WorkerModel model)
        {
            if (model == null) throw new ArgumentNullException();

            if (model.Name.Length > 50) return null; //возвращаем предполагаемый тип ответа в данной ситуации

            var domain = _service.AddWorker(model);

            return domain.ToModel();
        }

       
        
    }

}

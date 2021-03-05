
using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Models;
using Supermarket.Domain.Servises.Interfaces;
using Supermarket.Models;
using SupermarketMappers;
using System;

namespace Supermarket.Domain.Servises
{

    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository _repository;

        public WorkerService(IWorkerRepository repository)
        {
            _repository = repository;
        }

        public Worker AddWorker(WorkerModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var domain = model.ToDomain();

            //Do some logic

            var entity = _repository.AddWorker(domain);

            return entity.ToDomain();
        }
    }
}


using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Models;
using Supermarket.Entites;
using System;

namespace Supermarket.Data.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        public Worker Create(Worker model)
        {
            using (var context = new SupermarketContext("Supermarket"))
            {
                var worker1 = new Worker()
                {
                    Name = "Super Sus"
                };

            }

            using (var context = new SupermarketContext("Supermarket"))
            {
                var worker2 = new Worker()
                {
                    Name = "Sergey"
                };

            }


            return model;

        }

        public WorkerEntity AddWorker(Worker domain)
        {
            if (domain == null) throw new ArgumentNullException(nameof(domain));

            //to DB

            return null;
        }
    }
}

using Supermarket.Domain.Models;
using Supermarket.Entites;

namespace Supermarket.Data.Repositories.Interfases
{
    public interface IWorkerRepository
    {
        WorkerEntity AddWorker(Worker domain);
        Worker Create(Worker model);
    }
}

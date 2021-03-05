using Supermarket.Domain.Models;
using Supermarket.Models;

namespace Supermarket.Domain.Servises.Interfaces
{
    public interface IWorkerService
    {
        Worker AddWorker(WorkerModel model);
    }
}

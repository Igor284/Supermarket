using Supermarket.Controllers;
using Supermarket.Data.Repositories;
using Supermarket.Domain.Models;
using Supermarket.Domain.Servises;

namespace Supermarket.Console
{
    class Program
    {
        static void Main (string[] args)
        {
            var repository = new WorkerEFRepository();
            var service = new WorkerService(repository);
            var controller = new WorkerController(service);

            /*var workerModel = new WorkerModel();          
            controller.AddWorker(workerModel);*/

            var worker = new Worker();
            repository.Create(worker);
            System.Console.WriteLine(worker);
        }
    }
}

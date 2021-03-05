using Supermarket.Domain.Models;
using Supermarket.Entites;
using Supermarket.Models;
 

namespace SupermarketMappers
{
    public static class WorkerMapper
    {
        public static Worker ToDomain(this WorkerModel model)
        {
            return new Worker
            {
                Name = model.Name
            };
        }

        public static Worker ToDomain(this WorkerEntity entity)
        {
            return new Worker
            {
                Name = entity.Name
            };
        }


        public static WorkerEntity ToEntity(this Worker domain)
        {
            return new WorkerEntity
            {
                Name = domain.Name
            };
        }

        public static WorkerModel ToModel(this Worker domain)
        {
            return new WorkerModel
            {
                Name = domain.Name
            };
        }
    }
}

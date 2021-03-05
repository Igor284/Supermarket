using System.Collections.Generic;

namespace Supermarket.Entites
{
    public class DepartmentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductEntity> Products { get; set; }
        public virtual ICollection<WorkerEntity> Workers { get; set; }
    }
}

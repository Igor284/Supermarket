

using System.Collections.Generic;

namespace Supermarket.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }
        public virtual ICollection<WorkerModel> Workers { get; set; }
    }
}

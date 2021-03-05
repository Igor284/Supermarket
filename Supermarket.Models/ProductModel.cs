

namespace Supermarket.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeparnmentId { get; set; }
        public virtual DepartmentModel Department { get; set; }
    }
}

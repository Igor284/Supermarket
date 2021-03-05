

namespace Supermarket.Entites
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeparnmentId { get; set; }
        public virtual DepartmentEntity Department { get; set; }
    }
}

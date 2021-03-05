using Supermarket.Domain.Models;
using System.Collections.Generic;

namespace SupermarketDomainDtos
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection <Product> Products { get; set; }
        public virtual ICollection <Worker> Workers { get; set; }
    }
}

using Supermarket.Domain.Models;
using Supermarket.Entites;
using Supermarket.Models;


namespace SupermarketMappers
{
    public static class ProductMapper
    {
        public static Product ToDomain(this ProductModel model)
        {
            return new Product
            {
                Name = model.Name
            };
        }

        public static Product ToDomain(this ProductEntity entity)
        {
            return new Product
            {
                Name = entity.Name
            };
        }


        public static ProductEntity ToEntity(this Product domain)
        {
            return new ProductEntity
            {
                Name = domain.Name
            };
        }

        public static ProductModel ToModel(this Product domain)
        {
            return new ProductModel
            {
                Name = domain.Name
            };
        }
    }
}

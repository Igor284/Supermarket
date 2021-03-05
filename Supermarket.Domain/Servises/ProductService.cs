using Supermarket.Data.Repositories;
using Supermarket.Data.Repositories.Interfases;
using Supermarket.Domain.Models;
using Supermarket.Domain.Servises.Interfaces;
using Supermarket.Models;
using SupermarketMappers;
using System;


namespace Supermarket.Domain.Servises
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product AddProduct(ProductModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var domain = model.ToDomain();

            //Do some logic

            var entity = _repository.AddProduct(domain);

            return entity.ToDomain();
        }
    }

}

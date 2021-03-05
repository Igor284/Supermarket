using Supermarket.Domain.Servises.Interfaces;
using Supermarket.Models;
using SupermarketMappers;
using System;

namespace Supermarket.Controllers
{
    public class ProductController
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }


        public ProductModel AddProduct(ProductModel model)
        {
            if (model == null) throw new ArgumentNullException();

            if (model.Name.Length > 50) return null; //возвращаем предполагаемый тип ответа в данной ситуации

            var domain = _service.AddProduct(model);

            return domain.ToModel();
        }
    }
}

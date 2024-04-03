using ProductApiService.Shared_Layer.Interfaces;
using ProductApiService.Shared_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApiService.Business_Layer
{
    public class ProductRepositoryBL : IProductRepositoryBL
    {
        private readonly IProductRepository _productRepository;
        public ProductRepositoryBL(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductEntity AddProduct(ProductEntity product)
        {
            return _productRepository.AddProduct(product);
        }

        public ProductEntity DeleteProduct(Guid id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<ProductEntity> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public ProductEntity GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id);
        }
        public bool NotAvailable(Guid id)
        {
            return _productRepository.NotAvailable(id);
        }
    }
}

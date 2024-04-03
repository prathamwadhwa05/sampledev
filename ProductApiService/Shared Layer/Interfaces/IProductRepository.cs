using ProductApiService.Shared_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApiService.Shared_Layer.Interfaces
{
    public interface IProductRepository
    {
        List<ProductEntity> GetAllProducts();
        ProductEntity GetProductById(Guid id);
        ProductEntity AddProduct(ProductEntity product);
        ProductEntity DeleteProduct(Guid id);
        bool NotAvailable(Guid id);
    }
}

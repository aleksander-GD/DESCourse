using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTutorial
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts(IProductDiscountStrategy productDiscount)
        {
            IEnumerable<Product> productsFromDataStore = _productRepository.FindAll();
            foreach (Product p in productsFromDataStore)
            {
                p.AdjustPrice(productDiscount);
            }
            return productsFromDataStore;
        }
    }
}

using test.Interfaces;
using test.Models;

namespace test.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public void AddNewProduct(Product product)
        {

            _productRepo.Add(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepo.Delete(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
           return _productRepo.GetAllProducts();
        }
    }
}

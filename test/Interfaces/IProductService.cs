using test.Models;

namespace test.Interfaces
{
    public interface IProductService 
    {
        IEnumerable<Product> GetAllProducts();
        void AddNewProduct(Product product);
        bool DeleteProduct(int id);
    }

}

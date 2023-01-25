using test.Models;

namespace test.Interfaces
{
    public interface IProductRepo
    {

        IEnumerable<Product> GetAllProducts();
        void Add(Product product);
        bool Delete(int id);
    }
}

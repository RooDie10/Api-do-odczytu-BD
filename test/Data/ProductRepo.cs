using Microsoft.AspNetCore.Mvc;
using test.Interfaces;
using test.Models;

namespace test.Data
{
    public class ProductRepo : IProductRepo
    {
         public Random rng = new Random();

        private static List<Product> _products = new()
        {
            new Product{ Category = "rower", Description="sybki", Id=1, Name="jan",  Quantity=10 },
            new Product{ Category = "auto", Description="wolny", Id=2, Name="dzban", Quantity=6 },
            new Product{ Category = "krzeslo0", Description="zajete", Id=3, Name="franek", Quantity=16 }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            foreach (var item in _products)
            {
                item.Price = rng.Next(1,200);
            }
           //pobieranie danych z bazy danych
           return _products;
        }
        public void Add(Product product)
        {
            //dodawanie do bazy danych
            _products.Add(product);
        }

        public bool Delete(int id)
        {

            foreach(var item in _products)
            {
                if (item.Id == id)
                {
                    _products.Remove(item);
                    return true;
                }
            }

            return false;
            
        }
    }
}

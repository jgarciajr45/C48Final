using System.Collections.Generic;
using Testing.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    void UpdateProduct(Product product);
}
using System.Collections.Generic;
using Testing.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    void InsertProduct(Product productToInsert);
    IEnumerable<Category> GetCategories();
    Product AssignCategory();
    void UpdateProduct(Product product);
}
using System.Collections.Generic;
using Testing.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}

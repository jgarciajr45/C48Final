﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;

public class ProductController : Controller
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        var products = _repo.GetAllProducts();
        return View(products);
    }
    public IActionResult ViewProduct(int id)
    {
        var product = _repo.GetProduct(id);
        return View(product);
    }
    public IActionResult UpdateProduct(int id)
    {
        Product product = _repo.GetProduct(id);

        if (product == null)
        {
            return View("ProductNotFound");
        }

        return View(product);
    }

    [HttpPost]
    public IActionResult UpdateProductToDatabase(Product product)
    {
        _repo.UpdateProduct(product);
        return RedirectToAction("ViewProduct", new { id = product.ProductID });
    }
}

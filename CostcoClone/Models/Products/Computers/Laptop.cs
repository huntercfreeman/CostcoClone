using CostcoClone.Interfaces;
using CostcoClone.Interfaces.Departments;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products.Computers
{
    public class Laptop : IProduct, IComputers
    {
        public Laptop(string title, decimal price, int stock, MarkupString productDetails, IProductRepository productRepository, List<string> imageURLs)
        {
            Title = title;
            Price = price;
            Categories = new List<string> { "Computers", "Laptop" };
            Tags = new List<string> { "Computers", "Laptop" };
            Stock = stock;
            ProductDetails = productDetails;
            ProductId = Guid.NewGuid().ToString();
            ImageURLs = imageURLs;

            productRepository.AddComputer(this);
        }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Tags { get; set; }
        public int Stock { get; set; }
        public MarkupString ProductDetails { get; set; }
        public string ProductId { get; set; }
        public List<string> ImageURLs { get; set; }
    }
}

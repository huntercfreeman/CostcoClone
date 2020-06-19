using CostcoClone.Interfaces;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products
{
    public class Product : IProduct
    {
        public Product(string title, decimal price, int stock, MarkupString productDetails, IProductRepository productRepository, List<string> imageURLs)
        {
            Title = title;
            Price = price;
            Categories = new List<string> { "Appliances", "Quick Ship Appliances", "Fridge" };
            Tags = new List<string> { "Appliances", "Quick Ship Appliances", "Fridge" };
            Stock = stock;
            ProductDetails = productDetails;
            ProductId = Guid.NewGuid().ToString();
            ImageURLs = imageURLs;

            productRepository.AddProduct(this);
        }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Tags { get; set; }
        public int Stock { get; set; }
        public MarkupString ProductDetails { get; set; }
        public string ProductId { get; set; }
        public List<string> ImageURLs { get; set; }
        public bool Display { get => DisplayLinks != 0;  }
        public int DisplayLinks { get; set; }
    }
}

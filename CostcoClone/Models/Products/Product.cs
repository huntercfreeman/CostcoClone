using CostcoClone.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products
{
    public class Product : IProduct
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Tags { get; set; }
        public int Stock { get; set; }
        public MarkupString ProductDetails { get; set; }
        public string ProductId { get; set; }
        public List<string> ImageURLs { get; set; }
        public bool Display { get; set; }
    }
}

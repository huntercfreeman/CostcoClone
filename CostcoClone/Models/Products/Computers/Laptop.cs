using CostcoClone.Interfaces;
using CostcoClone.Interfaces.Departments;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products.Computers
{
    public class Laptop : Product, IComputers
    {
        public static Dictionary<Color, List<Laptop>> ColorFilter = new Dictionary<Color, List<Laptop>>();
        
        public Laptop(string title, decimal price, int stock, MarkupString productDetails, IProductRepository productRepository, List<string> imageURLs, Color color)
            : base(title, price, stock, productDetails, productRepository, imageURLs)
        {
            this.Color = color;
            if (ColorFilter.ContainsKey(color))
                ColorFilter[color].Add(this);
            else
            {
                ColorFilter.Add(color, new List<Laptop>());
                ColorFilter[color].Add(this);
            }

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
        public List<string> Features { get; set; }
        public string Resolution { get; set; }
        public string GraphicCard { get; set; }
        public Color Color { get; set; }
        public string Brand { get; set; }
        public string ComputerType { get; set; }
        public string HardDriveSize { get; set; }
        public string OperatingSystem { get; set; }
        public string Processor { get; set; }
        public string ScreenSize { get; set; }
        public string ScreenType { get; set; }
        public bool Display { get; set; }
    }
}

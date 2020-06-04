using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products.Computers.Laptops
{
    public class WindowsLaptop : Laptop
    {
        public WindowsLaptop(string title, decimal price, int stock, MarkupString productDetails, IProductRepository productRepository, List<string> imageURLs, Color color) 
            : base(title, price, stock, productDetails, productRepository, imageURLs, color)
        {
        }
    }
}

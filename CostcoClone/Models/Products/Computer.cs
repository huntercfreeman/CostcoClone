using CostcoClone.Interfaces.Departments;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products
{
    public class Computer : Product, IComputers
    {
        public Computer(string title, decimal price, int stock, MarkupString productDetails, IProductRepository productRepository, List<string> imageURLs)
            : base(title, price, stock, productDetails, productRepository, imageURLs)
        {
            productRepository.ComputerRepository.AddComputers(this);
        }
    }
}

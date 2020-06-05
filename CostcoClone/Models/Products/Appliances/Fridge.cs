using CostcoClone.Interfaces;
using CostcoClone.Interfaces.Departments;
using CostcoClone.Interfaces.Departments.Appliances;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products.Appliances
{
    public class Fridge : Product, IAppliance, IQuickShipAppliance
    {
        public Fridge(string title, decimal price, int stock, MarkupString productDetails, IProductRepository productRepository, List<string> imageURLs)
            : base(title, price, stock, productDetails, productRepository, imageURLs)
        {
            

            
        }
    }
}

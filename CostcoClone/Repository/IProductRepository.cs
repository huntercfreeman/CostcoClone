using CostcoClone.Interfaces;
using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public interface IProductRepository
    {
        public void AddAppliance(IAppliance appliance);
        public void AddComputer(IComputers computer);
        public IList<IProduct> GetProducts();
        public IList<IProduct> GetProductsByTitle(string title);
        public IProduct GetProductById(string productId);
    }
}

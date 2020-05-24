using CostcoClone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public interface IProductRepository
    {
        public IList<IProduct> GetProducts();
        public IList<IProduct> GetProductsByTitle(string title);
    }
}

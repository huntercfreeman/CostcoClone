using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class OfficeProductsRepository : IOfficeProductsRepository
    {
        private List<IOfficeProducts> _officeProducts = new List<IOfficeProducts>();
        public void AddOfficeProducts(IOfficeProducts officeProducts)
        {
            this._officeProducts.Add(officeProducts);
        }
    }
}

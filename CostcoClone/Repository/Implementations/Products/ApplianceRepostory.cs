using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ApplianceRepository : IApplianceRepository
    {
        private List<IAppliance> _appliances;

        public ApplianceRepository()
        {
            _appliances = new List<IAppliance>();
        }

        public void AddAppliance(IAppliance appliance)
        {
            _appliances.Add(appliance);
        }
    }
}

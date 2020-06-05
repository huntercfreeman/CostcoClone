using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ElectronicsRepository : IElectronicsRepository
    {
        private List<IElectronics> _electronics = new List<IElectronics>();
        public void AddElectronics(IElectronics electronics)
        {
            _electronics.Add(electronics);
        }
    }
}

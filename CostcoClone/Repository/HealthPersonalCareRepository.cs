using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class HealthPersonalCareRepository : IHealthPersonalCareRepository
    {
        private List<IHealthPersonalCare> _healthPersonalCares = new List<IHealthPersonalCare>();
        public void AddHealthPersonalCare(IHealthPersonalCare healthPersonalCare)
        {
            _healthPersonalCares.Add(healthPersonalCare);
        }
    }
}

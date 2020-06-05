using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class HomeImprovementRepository : IHomeImprovementRepository
    {
        private List<IHomeImprovement> _homeImprovements = new List<IHomeImprovement>();
        public void AddHomeImprovement(IHomeImprovement homeImprovement)
        {
            _homeImprovements.Add(homeImprovement);
        }
    }
}

using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class HomeKitchenRepository : IHomeKitchenRepository
    {
        private List<IHomeKitchen> _homeKitchens = new List<IHomeKitchen>();
        public void AddHomeKitchen(IHomeKitchen homeKitchen)
        {
            _homeKitchens.Add(homeKitchen);
        }
    }
}

using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class JewelryWatchesSunglassesRepository : IJewelryWatchesSunglassesRepository
    {
        private List<IJewelryWatchesSunglasses> _jewelryWatchesSunglasses = new List<IJewelryWatchesSunglasses>();
        public void AddJewelryWatchesSunglasses(IJewelryWatchesSunglasses jewelryWatchesSunglasses)
        {
            _jewelryWatchesSunglasses.Add(jewelryWatchesSunglasses);
        }
    }
}

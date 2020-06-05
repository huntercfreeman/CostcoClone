using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class GourmetFoodsRepository : IGourmetFoodsRepository
    {
        private List<IGourmetFoods> _gourmetFoods = new List<IGourmetFoods>();
        public void AddGourmetFoods(IGourmetFoods gourmetFoods)
        {
            _gourmetFoods.Add(gourmetFoods);
        }
    }
}

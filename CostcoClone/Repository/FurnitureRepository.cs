using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private List<IFurniture> _furnitures = new List<IFurniture>();
        public void AddFurniture(IFurniture furniture)
        {
            _furnitures.Add(furniture);
        }
    }
}

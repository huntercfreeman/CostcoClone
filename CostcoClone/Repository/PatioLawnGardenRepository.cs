using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class PatioLawnGardenRepository : IPatioLawnGardenRepository
    {
        private List<IPatioLawnGarden> _patioLawnGardens = new List<IPatioLawnGarden>();
        public void AddPatioLawnGarden(IPatioLawnGarden patioLawnGarden)
        {
            _patioLawnGardens.Add(patioLawnGarden);
        }
    }
}

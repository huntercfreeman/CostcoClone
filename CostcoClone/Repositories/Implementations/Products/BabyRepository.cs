using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class BabyRepository : IBabyRepository
    {
        private List<IBaby> _babies = new List<IBaby>();

        public void AddBaby(IBaby baby)
        {
            _babies.Add(baby);
        }
    }
}

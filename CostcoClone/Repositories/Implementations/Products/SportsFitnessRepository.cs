using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class SportsFitnessRepository : ISportsFitnessRepository
    {
        private List<ISportsFitness> _sportsFitnesses = new List<ISportsFitness>();
        public void AddSportsFitness(ISportsFitness sportsFitness)
        {
            _sportsFitnesses.Add(sportsFitness);
        }
    }
}

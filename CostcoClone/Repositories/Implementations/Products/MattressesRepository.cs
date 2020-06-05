using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class MattressesRepository : IMattressesRepository
    {
        private List<IMattresses> _mattresses = new List<IMattresses>();
        public void AddMattresses(IMattresses mattresses)
        {
            _mattresses.Add(mattresses);
        }
    }
}

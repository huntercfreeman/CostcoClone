using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ComputerRepository : IComputerRepository
    {
        private List<IComputers> _computers = new List<IComputers>();
        public void AddComputers(IComputers computers)
        {
            _computers.Add(computers);
        }
    }
}

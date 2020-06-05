using CostcoClone.Interfaces.Departments;
using CostcoClone.Interfaces.Departments.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public interface IComputerRepository
    {
        public ILaptopsNotebookComputersRepository LaptopsNotebookComputersRepository { get; set; }
        public void AddComputers(IComputers toyBook);
    }
}

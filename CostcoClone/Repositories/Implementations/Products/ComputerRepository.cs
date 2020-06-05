using CostcoClone.Interfaces.Departments;
using CostcoClone.Interfaces.Departments.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ComputerRepository : IComputerRepository
    {
        public ComputerRepository(ILaptopsNotebookComputersRepository laptopsNotebookComputersRepository)
        {
            LaptopsNotebookComputersRepository = laptopsNotebookComputersRepository;
        }

        private List<IComputers> _computers = new List<IComputers>();

        public ILaptopsNotebookComputersRepository LaptopsNotebookComputersRepository { get; set; }

        public void AddComputers(IComputers computers)
        {
            _computers.Add(computers);
        }
    }
}

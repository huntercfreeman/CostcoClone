using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Interfaces.Departments.Computers
{
    public interface ILaptopsNotebookComputersRepository
    {

        public Dictionary<string, Dictionary<string, List<ILaptopsNotebookComputers>>> Filters { get; set; }
        public void AddLaptopsNotebookComputer(ILaptopsNotebookComputers laptopsNotebookComputer);

        public IList<ILaptopsNotebookComputers> GetLaptopsNotebookComputers();
        public IList<ILaptopsNotebookComputers> GetLaptopsNotebookComputersByTitle(string title);
        public ILaptopsNotebookComputers GetLaptopsNotebookComputerById(string productId);
    }
}

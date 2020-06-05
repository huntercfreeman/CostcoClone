using CostcoClone.Interfaces.Departments.Computers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repositories.Implementations.Products.Computer
{
    public class LaptopsNotebookComputersRepository : ILaptopsNotebookComputersRepository
    {
        private List<ILaptopsNotebookComputers> _laptopsNotebookComputers = new List<ILaptopsNotebookComputers>();

        private Dictionary<string, List<ILaptopsNotebookComputers>> featuresFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();

        public void AddLaptopsNotebookComputer(ILaptopsNotebookComputers laptopsNotebookComputer)
        {
            _laptopsNotebookComputers.Add(laptopsNotebookComputer);

            // calculate filters
            foreach(string feature in laptopsNotebookComputer.Features)
            {
                if (!featuresFilter.ContainsKey(feature))
                    featuresFilter.Add(feature, new List<ILaptopsNotebookComputers>());
                featuresFilter[feature].Add(laptopsNotebookComputer);
            }
            
        }

        public ILaptopsNotebookComputers GetLaptopsNotebookComputerById(string productId)
        {
            throw new NotImplementedException();
        }

        public IList<ILaptopsNotebookComputers> GetLaptopsNotebookComputers()
        {
            throw new NotImplementedException();
        }

        public IList<ILaptopsNotebookComputers> GetLaptopsNotebookComputersByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}

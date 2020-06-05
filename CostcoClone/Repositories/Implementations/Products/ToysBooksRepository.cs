using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ToysBooksRepository : IToysBooksRepository
    {
        private List<IToysBooks> _toysBooks = new List<IToysBooks>();
        public void AddToyBook(IToysBooks toyBook)
        {
            _toysBooks.Add(toyBook);
        }
    }
}

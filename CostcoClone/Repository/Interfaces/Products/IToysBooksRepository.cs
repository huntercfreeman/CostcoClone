using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public interface IToysBooksRepository
    {
        public void AddToyBook(IToysBooks toyBook); 
    }
}

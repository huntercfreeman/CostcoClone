using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public interface IHealthPersonalCareRepository
    {
        public void AddHealthPersonalCare(IHealthPersonalCare toyBook);
    }
}

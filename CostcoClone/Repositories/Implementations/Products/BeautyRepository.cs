using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class BeautyRepository : IBeautyRepository
    {
        private List<IBeauty> _beauties = new List<IBeauty>();
        public void AddBeauty(IBeauty beauty)
        {
            _beauties.Add(beauty);
        }
    }
}

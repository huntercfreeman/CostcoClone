using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class FloralGiftBasketsRepository : IFloralGiftBasketsRepository
    {
        private List<IFloralGiftBaskets> _floralGiftBaskets = new List<IFloralGiftBaskets>();
        public void AddFloralGiftBaskets(IFloralGiftBaskets floralGiftBaskets)
        {
            _floralGiftBaskets.Add(floralGiftBaskets);
        }
    }
}

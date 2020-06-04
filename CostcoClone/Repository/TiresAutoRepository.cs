using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class TiresAutoRepository : ITiresAutoRepository
    {
        private List<ITiresAuto> _tiresAutos = new List<ITiresAuto>();
        public void AddTiresAuto(ITiresAuto tiresAuto)
        {
            _tiresAutos.Add(tiresAuto);
        }
    }
}

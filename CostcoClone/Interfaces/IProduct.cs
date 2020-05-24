using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Interfaces
{
    public interface IProduct
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Tags { get; set; }
        public int Stock { get; set; }
    }
}

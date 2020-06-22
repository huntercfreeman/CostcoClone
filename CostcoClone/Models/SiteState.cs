using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models
{
    public class SiteState
    {
        public event EventHandler<bool> FilterEventHandler;
        public void FilterEventInvoke(bool clearAll)
        {
            EventHandler<bool> handler = FilterEventHandler;
            handler?.Invoke(this, clearAll);
        }
        public bool IsFiltering 
        {
            get => FilterCount != 0;
        }
        public int FilterCount { get; set; }

        public string CurrentDepartment { get; set; } = "ComputerRepository";
        public string CurrentCategory { get; set; } = "LaptopsNotebookComputersRepository";
    }
}

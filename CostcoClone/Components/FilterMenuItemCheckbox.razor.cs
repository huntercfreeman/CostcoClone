using CostcoClone.Interfaces;
using CostcoClone.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Components
{
    public partial class FilterMenuItemCheckbox<TItem> : ComponentBase, IDisposable
    {
        [Inject]
        public SiteState SiteState { get; set; }
        [Parameter]
        public KeyValuePair<string, List<TItem>> Filter { get; set; }
        public bool IsChecked { get; set; }

        public void Dispose()
        {
            if (IsChecked) FilterOn();
        }

        protected void FilterOn()
        {
            IsChecked = !IsChecked;
            if (IsChecked)
            {
                foreach (TItem item in Filter.Value)
                {
                    ((IProduct)item).DisplayLinks++;
                }
                SiteState.FilterCount++;
            }
            else
            {
                foreach (TItem item in Filter.Value)
                {
                    ((IProduct)item).DisplayLinks--;
                }
                SiteState.FilterCount--;
            }
            
            SiteState.FilterEventInvoke(false);
        }
    }
}

using CostcoClone.Interfaces;
using CostcoClone.Models;
using CostcoClone.Models.Products;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Components
{
    public partial class FilterMenuItem<TItem> : ComponentBase
    {
        [Inject]
        public SiteState SiteState { get; set; }
        [Parameter]
        public bool IsCollapsed { get; set; } = true;
        
        [Parameter]
        public RenderFragment CustomContent { get; set; }
        [Parameter]
        public string DisplayText { get; set; }
        [Parameter]
        public Dictionary<string, List<TItem>> Filter { get; set; }
        
        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.FilterEventHandler += SiteState_FilterEventHandler;
        }

        private void SiteState_FilterEventHandler(object sender, bool clearAll)
        {
            if (clearAll)
            {
                IsCollapsed = true;
                InvokeAsync(StateHasChanged);
            }
        }
    }
}

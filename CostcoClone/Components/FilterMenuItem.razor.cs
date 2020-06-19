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
        
        [Parameter]
        public bool IsCollapsed { get; set; } = true;
        
        [Parameter]
        public RenderFragment CustomContent { get; set; }
        [Parameter]
        public string DisplayText { get; set; }
        [Parameter]
        public Dictionary<string, List<TItem>> Filter { get; set; }
        
    }
}

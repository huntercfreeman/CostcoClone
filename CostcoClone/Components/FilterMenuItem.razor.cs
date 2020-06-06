using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Components
{
    public partial class FilterMenuItem : ComponentBase
    {
        [Parameter]
        public bool IsCollapsed { get; set; } = true;
        [Parameter]
        public RenderFragment CustomContent { get; set; }
    }
}

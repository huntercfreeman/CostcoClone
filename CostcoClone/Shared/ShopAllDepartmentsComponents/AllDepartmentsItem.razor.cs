using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Shared.ShopAllDepartmentsComponents
{
    public partial class AllDepartmentsItem : ComponentBase
    {
        [Parameter]
        public EventCallback<RenderFragment> ExpansionCallbackOver { get; set; }
        [Parameter]
        public EventCallback<RenderFragment> ExpansionCallbackOut { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        [Parameter]
        public string Title { get; set; }
    }
}

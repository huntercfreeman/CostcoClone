using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Shared.ShopAllDepartmentsComponents
{
    public partial class ShopAllDepartmentsItem<TViewModel> : ComponentBase
    {
        [Parameter]
        public string MarkupText { get; set; }
        [Parameter]
        public TViewModel ViewModel { get; set; }
        [Parameter]
        public RenderFragment<TViewModel> ChildContent { get; set; }
        [Parameter]
        public EventCallback<TViewModel> OnMouseOverEventCallback { get; set; }
        [Parameter]
        public EventCallback<TViewModel> OnMouseOutEventCallback { get; set; }
        [Parameter]
        public int Left { get; set; }

        public bool DisplayDropdownContent { get; set; }

        public async void OnMouseOver()
        {
            if (OnMouseOverEventCallback.HasDelegate) await OnMouseOverEventCallback.InvokeAsync(default);

            DisplayDropdownContent = true;
        }

        public async void OnMouseOut()
        {
            if (OnMouseOutEventCallback.HasDelegate) await OnMouseOutEventCallback.InvokeAsync(default);

            DisplayDropdownContent = false;
        }
    }
}

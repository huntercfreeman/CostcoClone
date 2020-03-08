﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Shared.ShopAllDepartmentsComponents
{
    public partial class ShopAllDepartmentsItem : ComponentBase
    {
        [Parameter]
        public string MarkupText { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        [Parameter]
        public EventCallback OnMouseOverEventCallback { get; set; }
        [Parameter]
        public EventCallback OnMouseOutEventCallback { get; set; }
        [Parameter]
        public int Left { get; set; }

        public bool DisplayDropdownContent { get; set; }

        public async void OnMouseOver()
        {
            if (OnMouseOverEventCallback.HasDelegate) await OnMouseOverEventCallback.InvokeAsync(this);

            DisplayDropdownContent = true;
        }

        public async void OnMouseOut()
        {
            if (OnMouseOutEventCallback.HasDelegate) await OnMouseOutEventCallback.InvokeAsync(this);

            DisplayDropdownContent = false;
        }
    }
}
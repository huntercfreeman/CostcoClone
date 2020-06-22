using CostcoClone.Models;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Pages
{
    public partial class SearchPage : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IProductRepository ProductRepository { get; set; }
        [Inject]
        public SiteState SiteState { get; set; }
        [Parameter]
        public string Department { get; set; } = "All";
        [Parameter]
        public string Query { get; set; } = "";

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SiteState.FilterEventHandler += SiteState_FilterEventHandler;
        }

        private void SiteState_FilterEventHandler(object sender, bool clearAll)
        {
            InvokeAsync(StateHasChanged);
        }
        protected void NavigateToProduct(string Id)
        {
            NavigationManager.NavigateTo($"Products/{Id}");
        }

    }
}

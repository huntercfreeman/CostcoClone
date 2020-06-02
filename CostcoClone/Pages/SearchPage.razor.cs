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
        public IProductRepository ProductRepository { get; set; }
        [Parameter]
        public string Department { get; set; } = "All";
        [Parameter]
        public string Query { get; set; } = "";
    }
}

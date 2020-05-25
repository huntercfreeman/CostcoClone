using CostcoClone.Interfaces;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Pages
{
    public partial class ProductPage : ComponentBase
    {
        [Inject]
        public IProductRepository ProductRepository { get; set; }
        [Parameter]
        public string ProductId { get; set; }

        public IProduct Product { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            Product =   ProductRepository.GetProductById(ProductId);
        }
    }
}

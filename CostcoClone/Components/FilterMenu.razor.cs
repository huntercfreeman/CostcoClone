using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Components
{
    public partial class FilterMenu : ComponentBase
    {
        [Inject]
        public IProductRepository ProductRepository { get; set; }
    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Shared.HeaderComponents
{
    public partial class GetEmailOffers : ComponentBase
    {
        [Parameter]
        public GetEmailOffersViewModel ViewModel { get; set; }
    }
}

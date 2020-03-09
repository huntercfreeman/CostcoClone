using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Shared.HeaderComponents
{
    public class GetEmailOffersViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}

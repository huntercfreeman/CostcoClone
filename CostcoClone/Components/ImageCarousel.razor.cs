using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Components
{
    public partial class ImageCarousel : ComponentBase
    {
        [Parameter]
        public List<string> ImageURLs { get; set; } = new List<string> 
        { 
            "content/d-homepage-fq-20w0785-march-mailer-new-v.webp",
            "content/d-20w0780-fq-200303-ks-diapers-update.jpg",
            "content/d-homepage-hero-20w07109-pc-deals.jpg",
            "content/d-20w0747-hero-200228-furniture-v.jpg",
            "content/d-20w06167-fq-200224-bms-ends-soon.webp",
            "content/d-20w0795-fq-200309-samsung.jpg",
            "content/d-homepage-fq-20w0788-macbook.webp",
            "content/d-homepage-fq-200311-mvm-weatherproof.jpg",
            "content/d-homepage-hero-20w06140-bridgestone.jpg",
            "content/d-20w0725-fq-200302-travel.webp"
        };
        


    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Components
{
    public partial class ImageCarousel : ComponentBase, IDisposable
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

        public string IsSpinningCSS 
        {
            get => IsSpinning ? "" : "background-color: red;";
        }

        public bool IsSpinning { get; set; } = true;

        private int _index;
        public int Index 
        { 
            get
            {
                return _index;
            }
            set
            {
                if (value >= ImageURLs.Count) value = 0;
                else if (value < 0) value = ImageURLs.Count - 1;

                _index = value;
            }
        }

        public bool Alive { get; set; } = true;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Spin();
        }

        public string IsSelectedCSS(int index)
        {
            return Index == index ? "background-color: blue;" : "";
        }

        private async Task Spin()
        {
            while(Alive)
            {
                await Task.Delay(5000);
                if(IsSpinning) Index++;
                await InvokeAsync(StateHasChanged);
            }

            return;
        }

        public void Dispose()
        {
            Alive = false;
        }
    }
}

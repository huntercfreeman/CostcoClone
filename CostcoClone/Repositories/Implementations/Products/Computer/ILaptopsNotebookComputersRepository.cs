using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repositories.Implementations.Products.Computer
{
    public class ILaptopsNotebookComputersRepository
    {
        public List<string> Features { get; set; }
        public string DeliveryType { get; set; }
        public string Resolution { get; set; }
        public string GraphicCard { get; set; }
        public Color Color { get; set; }
        public string Brand { get; set; }
        public string ComputerType { get; set; }
        public string HardDriveSize { get; set; }
        public string OperatingSystem { get; set; }
        public string Processor { get; set; }
        public string ScreenSize { get; set; }
        public string ScreenType { get; set; }
    }
}

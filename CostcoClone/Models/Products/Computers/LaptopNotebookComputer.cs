using CostcoClone.Interfaces.Departments.Computers;
using CostcoClone.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Models.Products.Computers
{
    public class LaptopNotebookComputer : Computer, ILaptopsNotebookComputers
    {
        public LaptopNotebookComputer(string title, decimal price, int stock, MarkupString productDetails, 
            IProductRepository productRepository, List<string> imageURLs, Color color, List<string> features,
            string deliveryType, string resolution, string graphicCard, string brand, string computerType,
            string hardDriveSize, string operatingSystem, string processor, string screenSize,
            string screenType) 
            : base(title, price, stock, productDetails, productRepository, imageURLs)
        {
            this.Features = features;
            this.DeliveryType = deliveryType;
            this.Resolution = resolution;
            this.GraphicCard = graphicCard;
            this.Color = color;
            this.Brand = brand;
            this.ComputerType = computerType;
            this.HardDriveSize = hardDriveSize;
            this.OperatingSystem = operatingSystem;
            this.Processor = processor;
            this.ScreenSize = screenSize;
            this.ScreenType = screenType;


            productRepository.ComputerRepository.LaptopsNotebookComputersRepository.AddLaptopsNotebookComputer(this);
        }

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

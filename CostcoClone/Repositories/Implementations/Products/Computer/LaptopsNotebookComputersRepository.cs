using CostcoClone.Interfaces.Departments.Computers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repositories.Implementations.Products.Computer
{
    public class LaptopsNotebookComputersRepository : ILaptopsNotebookComputersRepository
    {
        private List<ILaptopsNotebookComputers> _laptopsNotebookComputers = new List<ILaptopsNotebookComputers>();

        private Dictionary<string, List<ILaptopsNotebookComputers>> featuresFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> deliveryTypeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> resolutionFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> graphicCardFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<Color, List<ILaptopsNotebookComputers>> colorFilter = new Dictionary<Color, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> brandFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> computerTypeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> hardDriveSizeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> operatingSystemFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> processorFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> screenSizeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private Dictionary<string, List<ILaptopsNotebookComputers>> screenTypeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();


        public void AddLaptopsNotebookComputer(ILaptopsNotebookComputers laptopsNotebookComputer)
        {
            _laptopsNotebookComputers.Add(laptopsNotebookComputer);

            // Features Filter Calculation
            foreach(string feature in laptopsNotebookComputer.Features)
            {
                if (!featuresFilter.ContainsKey(feature))
                    featuresFilter.Add(feature, new List<ILaptopsNotebookComputers>());
                featuresFilter[feature].Add(laptopsNotebookComputer);
            }

            // DeliveryType Filter Calculation
            if (!deliveryTypeFilter.ContainsKey(laptopsNotebookComputer.DeliveryType))
                deliveryTypeFilter.Add(laptopsNotebookComputer.DeliveryType, new List<ILaptopsNotebookComputers>());
            deliveryTypeFilter[laptopsNotebookComputer.DeliveryType].Add(laptopsNotebookComputer);

            // Resolution Filter Calculation
            if (!resolutionFilter.ContainsKey(laptopsNotebookComputer.Resolution))
                resolutionFilter.Add(laptopsNotebookComputer.Resolution, new List<ILaptopsNotebookComputers>());
            resolutionFilter[laptopsNotebookComputer.Resolution].Add(laptopsNotebookComputer);

            // GraphicCard Filter Calculation
            if (!graphicCardFilter.ContainsKey(laptopsNotebookComputer.GraphicCard))
                graphicCardFilter.Add(laptopsNotebookComputer.GraphicCard, new List<ILaptopsNotebookComputers>());
            graphicCardFilter[laptopsNotebookComputer.GraphicCard].Add(laptopsNotebookComputer);

            // Color Filter Calculation
            if (!colorFilter.ContainsKey(laptopsNotebookComputer.Color))
                colorFilter.Add(laptopsNotebookComputer.Color, new List<ILaptopsNotebookComputers>());
            colorFilter[laptopsNotebookComputer.Color].Add(laptopsNotebookComputer);

            // Brand Filter Calculation
            if (!brandFilter.ContainsKey(laptopsNotebookComputer.Brand))
                brandFilter.Add(laptopsNotebookComputer.Brand, new List<ILaptopsNotebookComputers>());
            brandFilter[laptopsNotebookComputer.Brand].Add(laptopsNotebookComputer);

            // ComputerType Filter Calculation
            if (!computerTypeFilter.ContainsKey(laptopsNotebookComputer.ComputerType))
                computerTypeFilter.Add(laptopsNotebookComputer.ComputerType, new List<ILaptopsNotebookComputers>());
            computerTypeFilter[laptopsNotebookComputer.ComputerType].Add(laptopsNotebookComputer);

            // HardDriveSize Filter Calculation
            if (!hardDriveSizeFilter.ContainsKey(laptopsNotebookComputer.HardDriveSize))
                hardDriveSizeFilter.Add(laptopsNotebookComputer.HardDriveSize, new List<ILaptopsNotebookComputers>());
            hardDriveSizeFilter[laptopsNotebookComputer.HardDriveSize].Add(laptopsNotebookComputer);

            // OperatingSystem Filter Calculation
            if (!operatingSystemFilter.ContainsKey(laptopsNotebookComputer.OperatingSystem))
                operatingSystemFilter.Add(laptopsNotebookComputer.OperatingSystem, new List<ILaptopsNotebookComputers>());
            operatingSystemFilter[laptopsNotebookComputer.OperatingSystem].Add(laptopsNotebookComputer);

            // Processor Filter Calculation
            if (!processorFilter.ContainsKey(laptopsNotebookComputer.Processor))
                processorFilter.Add(laptopsNotebookComputer.Processor, new List<ILaptopsNotebookComputers>());
            processorFilter[laptopsNotebookComputer.Processor].Add(laptopsNotebookComputer);

            // ScreenSize Filter Calculation
            if (!screenSizeFilter.ContainsKey(laptopsNotebookComputer.ScreenSize))
                screenSizeFilter.Add(laptopsNotebookComputer.ScreenSize, new List<ILaptopsNotebookComputers>());
            screenSizeFilter[laptopsNotebookComputer.ScreenSize].Add(laptopsNotebookComputer);

            // ScreenType Filter Calculation
            if (!screenTypeFilter.ContainsKey(laptopsNotebookComputer.ScreenType))
                screenTypeFilter.Add(laptopsNotebookComputer.ScreenType, new List<ILaptopsNotebookComputers>());
            screenTypeFilter[laptopsNotebookComputer.ScreenType].Add(laptopsNotebookComputer);
        }

        public ILaptopsNotebookComputers GetLaptopsNotebookComputerById(string productId)
        {
            throw new NotImplementedException();
        }

        public IList<ILaptopsNotebookComputers> GetLaptopsNotebookComputers()
        {
            throw new NotImplementedException();
        }

        public IList<ILaptopsNotebookComputers> GetLaptopsNotebookComputersByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}

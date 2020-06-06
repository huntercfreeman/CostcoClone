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
        private readonly List<ILaptopsNotebookComputers> _laptopsNotebookComputers = new List<ILaptopsNotebookComputers>();

        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _featuresFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _deliveryTypeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _resolutionFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _graphicCardFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _colorFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _brandFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _computerTypeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _hardDriveSizeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _operatingSystemFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _processorFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _screenSizeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();
        private readonly Dictionary<string, List<ILaptopsNotebookComputers>> _screenTypeFilter = new Dictionary<string, List<ILaptopsNotebookComputers>>();

        public Dictionary<string, Dictionary<string, List<ILaptopsNotebookComputers>>> Filters { get; set; }



        public void AddLaptopsNotebookComputer(ILaptopsNotebookComputers laptopsNotebookComputer)
        {
            _laptopsNotebookComputers.Add(laptopsNotebookComputer);

            Filters = new Dictionary<string, Dictionary<string, List<ILaptopsNotebookComputers>>>();

            Filters.Add("Features", _featuresFilter);
            Filters.Add("Delivery Type", _deliveryTypeFilter);
            Filters.Add("Resolution", _resolutionFilter);
            Filters.Add("Graphic Card", _graphicCardFilter);
            Filters.Add("Color", _colorFilter);
            Filters.Add("Brand", _brandFilter);
            Filters.Add("Computer Type", _computerTypeFilter);
            Filters.Add("Hard Drive", _hardDriveSizeFilter);
            Filters.Add("Operating System", _operatingSystemFilter);
            Filters.Add("Processor", _processorFilter);
            Filters.Add("Screen Size", _screenSizeFilter);
            Filters.Add("Screen Type", _screenTypeFilter);



            // Features Filter Calculation
            foreach (string feature in laptopsNotebookComputer.Features)
            {
                if (!_featuresFilter.ContainsKey(feature))
                    _featuresFilter.Add(feature, new List<ILaptopsNotebookComputers>());
                _featuresFilter[feature].Add(laptopsNotebookComputer);
            }

            // DeliveryType Filter Calculation
            if (!_deliveryTypeFilter.ContainsKey(laptopsNotebookComputer.DeliveryType))
                _deliveryTypeFilter.Add(laptopsNotebookComputer.DeliveryType, new List<ILaptopsNotebookComputers>());
            _deliveryTypeFilter[laptopsNotebookComputer.DeliveryType].Add(laptopsNotebookComputer);

            // Resolution Filter Calculation
            if (!_resolutionFilter.ContainsKey(laptopsNotebookComputer.Resolution))
                _resolutionFilter.Add(laptopsNotebookComputer.Resolution, new List<ILaptopsNotebookComputers>());
            _resolutionFilter[laptopsNotebookComputer.Resolution].Add(laptopsNotebookComputer);

            // GraphicCard Filter Calculation
            if (!_graphicCardFilter.ContainsKey(laptopsNotebookComputer.GraphicCard))
                _graphicCardFilter.Add(laptopsNotebookComputer.GraphicCard, new List<ILaptopsNotebookComputers>());
            _graphicCardFilter[laptopsNotebookComputer.GraphicCard].Add(laptopsNotebookComputer);

            // Color Filter Calculation
            if (!_colorFilter.ContainsKey(laptopsNotebookComputer.Color.ToString()))
                _colorFilter.Add(laptopsNotebookComputer.Color.ToString(), new List<ILaptopsNotebookComputers>());
            _colorFilter[laptopsNotebookComputer.Color.ToString()].Add(laptopsNotebookComputer);

            // Brand Filter Calculation
            if (!_brandFilter.ContainsKey(laptopsNotebookComputer.Brand))
                _brandFilter.Add(laptopsNotebookComputer.Brand, new List<ILaptopsNotebookComputers>());
            _brandFilter[laptopsNotebookComputer.Brand].Add(laptopsNotebookComputer);

            // ComputerType Filter Calculation
            if (!_computerTypeFilter.ContainsKey(laptopsNotebookComputer.ComputerType))
                _computerTypeFilter.Add(laptopsNotebookComputer.ComputerType, new List<ILaptopsNotebookComputers>());
            _computerTypeFilter[laptopsNotebookComputer.ComputerType].Add(laptopsNotebookComputer);

            // HardDriveSize Filter Calculation
            if (!_hardDriveSizeFilter.ContainsKey(laptopsNotebookComputer.HardDriveSize))
                _hardDriveSizeFilter.Add(laptopsNotebookComputer.HardDriveSize, new List<ILaptopsNotebookComputers>());
            _hardDriveSizeFilter[laptopsNotebookComputer.HardDriveSize].Add(laptopsNotebookComputer);

            // OperatingSystem Filter Calculation
            if (!_operatingSystemFilter.ContainsKey(laptopsNotebookComputer.OperatingSystem))
                _operatingSystemFilter.Add(laptopsNotebookComputer.OperatingSystem, new List<ILaptopsNotebookComputers>());
            _operatingSystemFilter[laptopsNotebookComputer.OperatingSystem].Add(laptopsNotebookComputer);

            // Processor Filter Calculation
            if (!_processorFilter.ContainsKey(laptopsNotebookComputer.Processor))
                _processorFilter.Add(laptopsNotebookComputer.Processor, new List<ILaptopsNotebookComputers>());
            _processorFilter[laptopsNotebookComputer.Processor].Add(laptopsNotebookComputer);

            // ScreenSize Filter Calculation
            if (!_screenSizeFilter.ContainsKey(laptopsNotebookComputer.ScreenSize))
                _screenSizeFilter.Add(laptopsNotebookComputer.ScreenSize, new List<ILaptopsNotebookComputers>());
            _screenSizeFilter[laptopsNotebookComputer.ScreenSize].Add(laptopsNotebookComputer);

            // ScreenType Filter Calculation
            if (!_screenTypeFilter.ContainsKey(laptopsNotebookComputer.ScreenType))
                _screenTypeFilter.Add(laptopsNotebookComputer.ScreenType, new List<ILaptopsNotebookComputers>());
            _screenTypeFilter[laptopsNotebookComputer.ScreenType].Add(laptopsNotebookComputer);
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

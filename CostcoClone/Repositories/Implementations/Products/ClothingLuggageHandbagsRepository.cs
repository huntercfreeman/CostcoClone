using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ClothingLuggageHandbagsRepository : IClothingLuggageHandbagsRepository
    {
        private List<IClothingLuggageHandbags> _clothingLuggageHandbags = new List<IClothingLuggageHandbags>();
        public void AddClothingLuggageHandbags(IClothingLuggageHandbags clothingLuggageHandbags)
        {
            _clothingLuggageHandbags.Add(clothingLuggageHandbags);
        }
    }
}

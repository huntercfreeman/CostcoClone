using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class FoodHouseholdPetRepository : IFoodHouseholdPetRepository
    {
        private List<IFoodhouseholdPet> _foodhouseholdPets = new List<IFoodhouseholdPet>();
        public void AddFoodhouseholdPet(IFoodhouseholdPet foodhouseholdPets)
        {
            _foodhouseholdPets.Add(foodhouseholdPets);
        }
    }
}

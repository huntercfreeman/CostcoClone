using CostcoClone.Interfaces;
using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public interface IProductRepository
    {

        public void AddAppliance(IAppliance appliance);
        public void AddBaby(IBaby appliance);
        public void AddClothingLuggageHandbags(IClothingLuggageHandbags appliance);
        public void AddComputer(IComputers appliance);
        public void AddElectronic(IElectronics appliance);
        public void AddFloralGiftBasket(IFloralGiftBaskets appliance);
        public void AddFoodhouseholdPet(IFoodhouseholdPet appliance);
        public void AddFurniture(IFurniture appliance);
        public void AddGiftCardTicket(IGiftCardsTickets appliance);
        public void AddGourmetFood(IGourmetFoods appliance);
        public void AddHealthPersonalCare(IHealthPersonalCare appliance);
        public void AddHomeImprovement(IHomeImprovement appliance);
        public void AddHomeKitchen(IHomeKitchen appliance);
        public void AddJewelryWatchSunglasses(IJewelryWatchesSunglasses appliance);
        public void AddMattress(IMattresses appliance);
        public void AddOfficeProduct(IOfficeProducts appliance);
        public void AddPatioLawnGarden(IPatioLawnGarden appliance);
        public void AddSportFitness(ISportsFitness appliance);
        public void AddTireAuto(ITiresAuto appliance);
        public void AddToyBook(IToysBooks appliance);
        public void AddProduct(IProduct product);

        public IList<IProduct> GetProducts();
        public IList<IProduct> GetProductsByTitle(string title);
        public IProduct GetProductById(string productId);
    }
}

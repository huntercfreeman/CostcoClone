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
        public IApplianceRepository ApplianceRepository { get; set; }
        public IBabyRepository BabyRepository { get; set; }
        public IBeautyRepository BeautyRepository { get; set; }
        public IClothingLuggageHandbagsRepository ClothingLuggageHandbagsRepository { get; set; }
        public IComputerRepository ComputerRepository { get; set; }
        public IElectronicsRepository ElectronicsRepository { get; set; }
        public IFloralGiftBasketsRepository FloralGiftBasketsRepository { get; set; }
        public IFoodHouseholdPetRepository FoodHouseholdPetRepository { get; set; }
        public IFurnitureRepository FurnitureRepository { get; set; }
        public IGiftCardsTicketsRepository GiftCardsTicketsRepository { get; set; }
        public IGourmetFoodsRepository GourmetFoodsRepository { get; set; }
        public IHealthPersonalCareRepository HealthPersonalCareRepository { get; set; }
        public IHomeImprovementRepository HomeImprovementRepository { get; set; }
        public IHomeKitchenRepository HomeKitchenRepository { get; set; }
        public IJewelryWatchesSunglassesRepository JewelryWatchesSunglassesRepository { get; set; }
        public IMattressesRepository MattressesRepository { get; set; }
        public IOfficeProductsRepository OfficeProductsRepository { get; set; }
        public IPatioLawnGardenRepository PatioLawnGardenRepository { get; set; }
        public ISportsFitnessRepository SportsFitnessRepository { get; set; }
        public ITiresAutoRepository TiresAutoRepository { get; set; }
        public IToysBooksRepository ToysBooksRepository { get; set; }


        public void AddProduct(IProduct product);

        public IList<IProduct> GetProducts();
        public IList<IProduct> GetProductsByTitle(string title);
        public IProduct GetProductById(string productId);
    }
}

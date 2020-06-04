using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CostcoClone.Data;
using CostcoClone.Repository;

namespace CostcoClone
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<IApplianceRepository, ApplianceRepository>();
            services.AddSingleton<IBabyRepository, BabyRepository>();
            services.AddSingleton<IBeautyRepository, BeautyRepository>();
            services.AddSingleton<IClothingLuggageHandbagsRepository, ClothingLuggageHandbagsRepository>();
            services.AddSingleton<IComputerRepository, ComputerRepository>();
            services.AddSingleton<IElectronicsRepository, ElectronicsRepository>();
            services.AddSingleton<IFloralGiftBasketsRepository, FloralGiftBasketsRepository>();
            services.AddSingleton<IFoodHouseholdPetRepository, FoodHouseholdPetRepository>();
            services.AddSingleton<IFurnitureRepository, FurnitureRepository>();
            services.AddSingleton<IGiftCardsTicketsRepository, GiftCardsTicketsRepository>();
            services.AddSingleton<IGourmetFoodsRepository, GourmetFoodsRepository>();
            services.AddSingleton<IHealthPersonalCareRepository, HealthPersonalCareRepository>();
            services.AddSingleton<IHomeImprovementRepository, HomeImprovementRepository>();
            services.AddSingleton<IHomeKitchenRepository, HomeKitchenRepository>();
            services.AddSingleton<IJewelryWatchesSunglassesRepository, JewelryWatchesSunglassesRepository>();
            services.AddSingleton<IMattressesRepository, MattressesRepository>();
            services.AddSingleton<IOfficeProductsRepository, OfficeProductsRepository>();
            services.AddSingleton<IPatioLawnGardenRepository, PatioLawnGardenRepository>();
            services.AddSingleton<ISportsFitnessRepository, SportsFitnessRepository>();
            services.AddSingleton<ITiresAutoRepository, TiresAutoRepository>();
            services.AddSingleton<IToysBooksRepository, ToysBooksRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<OfficeProductsRepository, OfficeProductsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

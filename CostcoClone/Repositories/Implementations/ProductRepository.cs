﻿using CostcoClone.Interfaces;
using CostcoClone.Interfaces.Departments;
using CostcoClone.Models;
using CostcoClone.Models.Products;
using CostcoClone.Models.Products.Appliances;
using CostcoClone.Models.Products.Computers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<IProduct> _products = new List<IProduct>();

        public IList<IProduct> GetProducts()
        {
            return _products;
        }

        public IList<IProduct> GetProductsByTitle(string title)
        {
            return _products.Where(x => x.Title.Contains(title)).ToList();
        }

        public IProduct GetProductById(string productId)
        {
            return _products.Where(x => x.ProductId.CompareTo(productId) == 0).FirstOrDefault();
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

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

        public ProductRepository(IApplianceRepository applianceRepository, IBabyRepository babyRepository, IBeautyRepository beautyRepository,
                                IClothingLuggageHandbagsRepository clothingLuggageHandbagsRepository, IComputerRepository computerRepository,
                                IElectronicsRepository electronicsRepository, IFloralGiftBasketsRepository floralGiftBasketsRepository,
                                IFoodHouseholdPetRepository foodHouseholdPetRepository, IFurnitureRepository furnitureRepository,
                                IGiftCardsTicketsRepository giftCardsTicketsRepository, IGourmetFoodsRepository gourmetFoodsRepository,
                                IHealthPersonalCareRepository healthPersonalCareRepository, IHomeImprovementRepository homeImprovementRepository,
                                IHomeKitchenRepository homeKitchenRepository, IJewelryWatchesSunglassesRepository jewelryWatchesSunglassesRepository,
                                IMattressesRepository mattressesRepository, IOfficeProductsRepository officeProductsRepository,
                                IPatioLawnGardenRepository patioLawnGardenRepository, ITiresAutoRepository tiresAutoRepository,
                                IToysBooksRepository toysBooksRepository, ISportsFitnessRepository sportsFitnessRepository)
        {
            ApplianceRepository = applianceRepository;
            BabyRepository = babyRepository;
            BeautyRepository = beautyRepository;
            ClothingLuggageHandbagsRepository = clothingLuggageHandbagsRepository;
            ComputerRepository = computerRepository;
            ElectronicsRepository = electronicsRepository;
            FloralGiftBasketsRepository = floralGiftBasketsRepository;
            FoodHouseholdPetRepository = foodHouseholdPetRepository;
            FurnitureRepository = furnitureRepository;
            GiftCardsTicketsRepository = giftCardsTicketsRepository;
            GourmetFoodsRepository = gourmetFoodsRepository;
            HealthPersonalCareRepository = healthPersonalCareRepository;
            HomeImprovementRepository = homeImprovementRepository;
            HomeKitchenRepository = homeKitchenRepository;
            JewelryWatchesSunglassesRepository = jewelryWatchesSunglassesRepository;
            MattressesRepository = mattressesRepository;
            OfficeProductsRepository = officeProductsRepository;
            PatioLawnGardenRepository = patioLawnGardenRepository;
            TiresAutoRepository = tiresAutoRepository;
            ToysBooksRepository = toysBooksRepository;
            SportsFitnessRepository = sportsFitnessRepository;

            Fridge k =
                new Fridge
                (
                    "GE 27 cu. ft. ENERGY STAR French-Door Refrigerator with Internal Water Dispenser",
                    (decimal)1298.70,
                    10,
                    (MarkupString)@"<div id='' class='' role='tabpanel' aria-labelledby='pdp-accordion-header-1'><div class='panel-body'><span class='view-more-height-default' data-height='600'></span><div id='product-tab1-espotdetails'><!-- BEGIN ContentAreaESpot.jsp -->
                        <div class='genericESpot' id='WC_ContentAreaESpot_div_1_ProductDetailsESpot_Tab1'>
                        <div class='caption' style='display:none' id='WC_ContentAreaESpot_div_2_ProductDetailsESpot_Tab1'>[ProductDetailsESpot_Tab1]</div> 
                        <div></div></div><!-- END ContentAreaESpot.jsp --></div><div class='product-info-description' style='max-height: none;'><span style='font-weight:bold;'>2-Year Manufacturer's Warranty Included</span><br><br><span style='font-weight:bold;'>Be Prepared for your Delivery. Read GE Appliances Home Delivery Guidelines PDF in Manuals, Information &amp; Guides section.</span><br><br><span style='font-weight:bold;'>Our delivery and installation teams are not authorized to perform any modifications to the home; no carpentry, plumbing or electrical work. Any work that would exceed the included basic installation will require additional payment by you to the installer. For your convenience and while at your home, the installer will be able to determine if any additional work and or permits are needed that would exceed the included basic installation. You will always be given a quote before work starts. You will be responsible for direct payment to the installer for any work exceeding basic installation.</span><br><br><!-- START prop65 -->
                        <div class='prop65warning'><img alt='WARNING' src='/wcsstore/CostcoUSBCCatalogAssetStore/feature-pages/prop-65-warning.png' style='width: 20px;height: auto;padding-bottom: 6px;'><span style='font-weight:bold;'>WARNING: </span> Cancer and Reproductive Harm - <a href='https://www.p65warnings.ca.gov' target='_blank' class='external'>www.P65Warnings.ca.gov</a>.</div>
                        <!-- END prop65 --><!--THIS IS A POWERPAGE-->
                        <div id='wc-power-page'><div class='wc-responsive wc-layout-computer wc-device-computer wc-8-col wc-wide wc-4-2col wc-3-3col wc-2-4col wc-rf-col-4 wc-rf-break-4-to-4 wc-rf-break-3-to-3 wc-richfeatures-layout-computer' id='wc-aplus'><h1 class='wc-ppp-caption'>Product details have been supplied by the Manufacturer, and are hosted by a third party.</h1><div class='wc-fragment wc-no-focus' data-channel-product-name='' data-compiler-v='2020.7.2.487' data-cpi='100421002' data-gtin='00084691853824' data-is-capdesc-open='false' data-language-code='en' data-module-brand='ecg-13848' data-module-code='qejiqloxmqmjysdroceqxbdsl' data-module-name='ecg-13848' data-mpn='GNE27EYMFS' data-produced='2020-05-22 16:01' data-section-caption='Interactive Tour' data-section-tag='demo' data-section-template-code='tour' data-vendor-name='27.0 Cu. Ft. Fingerprint Resistant French-Door Refrigerator' data-wcpc='1589815370307' id='wc-demo-c754a95707d5f84b4fa42bf87a4f0c7f' data-is-reported-view='true'><h2 class='wc-first-header'>Interactive Tour</h2><div class='wc-aplus-body'><div class='wc-tour-container wc-tour-outer' data-resources-base='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/'> <div class='wc-json-data' style='display: none !important'>{'hideMenu':false,'ipiOnly':false,'tourViews':[{'viewImage':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/0ab611a54aa7423b8e352e7f8a8bae5c.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/0ab611a54aa7423b8e352e7f8a8bae5c.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/0ab611a54aa7423b8e352e7f8a8bae5c.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/0ab611a54aa7423b8e352e7f8a8bae5c.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/0ab611a54aa7423b8e352e7f8a8bae5cjpg.','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/0ab611a54aa7423b8e352e7f8a8bae5cjpg..web.','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'0ab611a54aa7423b8e352e7f8a8bae5c.jpg','isAdaCompliant':false},'hotspots':[{'hotspotX':0.4010417,'hotspotY':0.345,'captionFromAttr':'Two humidity-controlled drawers and full-width drawer','description':'Create the right environment for keeping fruits and vegetables fresh, while easily storing wider items like a party platter or a sheet cake','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/501c8df2698c475796f5382bdd369c16.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/501c8df2698c475796f5382bdd369c16.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/501c8df2698c475796f5382bdd369c16.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/501c8df2698c475796f5382bdd369c16.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/501c8df2698c475796f5382bdd369c16.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/501c8df2698c475796f5382bdd369c16.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'501c8df2698c475796f5382bdd369c16.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.3958333,'hotspotY':0.195,'captionFromAttr':'Space-saving icemaker','description':'Located on the door with integrated bins to create more usable storage space','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e4c5039b6c1c4133ab47ef2dfa8d0347.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e4c5039b6c1c4133ab47ef2dfa8d0347.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e4c5039b6c1c4133ab47ef2dfa8d0347.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e4c5039b6c1c4133ab47ef2dfa8d0347.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e4c5039b6c1c4133ab47ef2dfa8d0347.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e4c5039b6c1c4133ab47ef2dfa8d0347.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'e4c5039b6c1c4133ab47ef2dfa8d0347.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.05729167,'hotspotY':0.055,'captionFromAttr':'LED lighting','description':'Find exactly what you\u2019ve been looking for under crisp, clear lighting','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/a4fee063515448ea919511e0f349776a.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/a4fee063515448ea919511e0f349776a.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/a4fee063515448ea919511e0f349776a.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/a4fee063515448ea919511e0f349776a.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/a4fee063515448ea919511e0f349776a.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/a4fee063515448ea919511e0f349776a.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'a4fee063515448ea919511e0f349776a.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.08854166,'hotspotY':0.43,'captionFromAttr':'External controls with actual temperature display, child lock and door alarm','description':'Eliminates the guesswork in setting refrigerator temperatures; conveniently displayed on the dispenser','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/ee55d9154fdc4a0b8f9d0cd37190d83a.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/ee55d9154fdc4a0b8f9d0cd37190d83a.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/ee55d9154fdc4a0b8f9d0cd37190d83a.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/ee55d9154fdc4a0b8f9d0cd37190d83a.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/ee55d9154fdc4a0b8f9d0cd37190d83a.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/ee55d9154fdc4a0b8f9d0cd37190d83a.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'ee55d9154fdc4a0b8f9d0cd37190d83a.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.6145833,'hotspotY':0.355,'captionFromAttr':'Spill-proof shelves','description':'A variety of shelf configurations provide additional options for food storage','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/64414093138144148254a2081b2d27a6.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/64414093138144148254a2081b2d27a6.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/64414093138144148254a2081b2d27a6.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/64414093138144148254a2081b2d27a6.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/64414093138144148254a2081b2d27a6.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/64414093138144148254a2081b2d27a6.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'64414093138144148254a2081b2d27a6.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.625,'hotspotY':0.235,'captionFromAttr':'Quick Space shelf','description':'Quickly slides out of the way to make room for tall items','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/6e7d05898b8b452ab5beb5277a5c831f.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/6e7d05898b8b452ab5beb5277a5c831f.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/6e7d05898b8b452ab5beb5277a5c831f.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/6e7d05898b8b452ab5beb5277a5c831f.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/6e7d05898b8b452ab5beb5277a5c831f.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/6e7d05898b8b452ab5beb5277a5c831f.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'6e7d05898b8b452ab5beb5277a5c831f.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.640625,'hotspotY':0.11,'captionFromAttr':'Advanced water filtration uses XWF replacement filter','description':'Reduces trace pharmaceuticals from water and ice* (* Removes 98% of ibuprofen, atenolol, fluoxetine, progesterone and trimethoprim. These pharmaceuticals are not necessarily in all users\u2019 water)','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/b5720509ffc24bb497cbfba9113a80f1.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/b5720509ffc24bb497cbfba9113a80f1.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/b5720509ffc24bb497cbfba9113a80f1.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/b5720509ffc24bb497cbfba9113a80f1.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/b5720509ffc24bb497cbfba9113a80f1.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/b5720509ffc24bb497cbfba9113a80f1.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'b5720509ffc24bb497cbfba9113a80f1.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.4739583,'hotspotY':0.785,'captionFromAttr':'Two-level freezer storage baskets','description':'Baskets allow easy access to frozen foods','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/8e800256a91d4bbe83e18b38b1567349.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/8e800256a91d4bbe83e18b38b1567349.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/8e800256a91d4bbe83e18b38b1567349.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/8e800256a91d4bbe83e18b38b1567349.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/8e800256a91d4bbe83e18b38b1567349.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/8e800256a91d4bbe83e18b38b1567349.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'8e800256a91d4bbe83e18b38b1567349.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'},{'hotspotX':0.8072917,'hotspotY':0.35,'captionFromAttr':'Gallon door storage','description':'Deep bins handle large containers in the door and free up valuable shelf space','media':{'sources':[{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e79a58244d1447d29d0e6fe617e921a9.jpg.w1920.jpg','width':1920,'height':2000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e79a58244d1447d29d0e6fe617e921a9.jpg.w960.jpg','width':960,'height':1000},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e79a58244d1447d29d0e6fe617e921a9.jpg.w480.jpg','width':480,'height':500},{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e79a58244d1447d29d0e6fe617e921a9.jpg.w240.jpg','width':240,'height':250}],'src':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e79a58244d1447d29d0e6fe617e921a9.jpg','width':2400,'height':2500},'runtimeSrc':{'src':'/_cp/products/1589815370307/tab-c754a957-07d5-f84b-4fa4-2bf87a4f0c7f/e79a58244d1447d29d0e6fe617e921a9.jpg.web.jpg','width':2400,'height':2500},'assetWrapper':'tour','editorOriginalName':'e79a58244d1447d29d0e6fe617e921a9.jpg','isAdaCompliant':false,'type':'IMAGE'},'direction':'left'}]}],'ipiCompatible':false}</div> <div class='wc-tour-container wc-tour-inner-container'><iframe frameborder='no' scrolling='no' title='Interactive Product Tour' allowfullscreen='true' webkitallowfullscreen='true' mozallowfullscreen='true' id='wcframable1-2' style='width: 100%; height: 602px;' class='data-iframe-viewed'></iframe></div> </div></div><div class='wc-clear-both' style='height: 0px !important'></div></div><div class='wc-fragment wc-no-focus' data-channel-product-name='' data-compiler-v='2020.7.2.487' data-cpi='100421002' data-gtin='00084691853824' data-is-capdesc-open='false' data-language-code='en' data-module-brand='ecg-13848' data-module-code='qejiqloxmqmjysdroceqxbdsl' data-module-name='ecg-13848' data-mpn='GNE27EYMFS' data-produced='2020-05-22 16:01' data-section-caption='Images' data-section-tag='features' data-section-template-code='image-gallery' data-vendor-name='27.0 Cu. Ft. Fingerprint Resistant French-Door Refrigerator' data-wcpc='1589815370307' id='wc-features-80357563f623289ccd2d28db1709d4f3' data-is-reported-view='true'><h2>Images</h2><div class='wc-aplus-body'><span> <div class='wc-mediaGallery' data-module-id='qejiqloxmqmjysdroceqxbdsl' data-resources-base='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/' data-wcpc='1589815370307' style='max-height: 1006px;'><iframe frameborder='no' scrolling='no' title='Product Views' allowfullscreen='true' webkitallowfullscreen='true' mozallowfullscreen='true' id='wcframable1-0' style='width: 100%; height: 1006px;' class='data-iframe-viewed'></iframe></div> <table cellspacing='0' class='wc-gallery-table wc-image-gallery-table' style='display:none;'> <tbody><tr class='wc-first-row wc-last-row'> <td class='wc-first-column wc-last-column wc-image-gallery-table'> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/a8640010542a4c40847d70bdd0f9f701.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='0' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/a8640010542a4c40847d70bdd0f9f701.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/a8640010542a4c40847d70bdd0f9f701.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/fe9069bab962473ba4bbdbdaedf6455b.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='1' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/fe9069bab962473ba4bbdbdaedf6455b.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/fe9069bab962473ba4bbdbdaedf6455b.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/bc43f91dff7148e689cd8ded65e55a62.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='2' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/bc43f91dff7148e689cd8ded65e55a62.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/bc43f91dff7148e689cd8ded65e55a62.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/b84786c303e54e64a15ed81ddadc964d.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='3' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/b84786c303e54e64a15ed81ddadc964d.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/b84786c303e54e64a15ed81ddadc964d.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/b12507dc15f84e309b4436cfe06f5f03.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='4' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/b12507dc15f84e309b4436cfe06f5f03.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/b12507dc15f84e309b4436cfe06f5f03.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/147b5357071643579451d786e59746ba.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='5' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/147b5357071643579451d786e59746ba.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/147b5357071643579451d786e59746ba.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/0f3df687f4c04159842dc60a99d097fc.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='6' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/0f3df687f4c04159842dc60a99d097fc.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/0f3df687f4c04159842dc60a99d097fc.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/8370bc8e61ec4a2bbf3bbb4ae615c69c.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='7' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/8370bc8e61ec4a2bbf3bbb4ae615c69c.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/8370bc8e61ec4a2bbf3bbb4ae615c69c.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/ef358b2be09747269ce68ae7c4712642.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='8' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/ef358b2be09747269ce68ae7c4712642.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/ef358b2be09747269ce68ae7c4712642.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label=' Enlarge Image'><img alt='' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/aa9e5d34b9ee4fcda44ec46949b5fa58.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='10' data-height='90' data-index-in-collection='9' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/aa9e5d34b9ee4fcda44ec46949b5fa58.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-80357563-f623-289c-cd2d-28db1709d4f3/aa9e5d34b9ee4fcda44ec46949b5fa58.jpg.w960.jpg' wcobj-height='1000' wcobj-type='image/*' wcobj-width='960' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> </td> </tr> </tbody></table> </span></div><div class='wc-clear-both' style='height: 0px !important'></div></div><div class='wc-fragment wc-no-focus' data-channel-product-name='' data-compiler-v='2020.7.2.487' data-cpi='100421002' data-gtin='00084691853824' data-is-capdesc-open='false' data-language-code='en' data-module-brand='ecg-13848' data-module-code='qejiqloxmqmjysdroceqxbdsl' data-module-name='ecg-13848' data-mpn='GNE27EYMFS' data-produced='2020-05-22 16:01' data-section-caption='Available Colors' data-section-tag='product-variants' data-section-template-code='image-gallery' data-vendor-name='27.0 Cu. Ft. Fingerprint Resistant French-Door Refrigerator' data-wcpc='1589815370307' id='wc-product-variants-2094881d9b630e9188ce388fb51f4ec3' data-is-reported-view='true'><h2>Available Colors</h2><div class='wc-aplus-body'><span> <div class='wc-mediaGallery' data-module-id='qejiqloxmqmjysdroceqxbdsl' data-resources-base='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/' data-wcpc='1589815370307' style='max-height: 501px;'><iframe frameborder='no' scrolling='no' title='Product Views' allowfullscreen='true' webkitallowfullscreen='true' mozallowfullscreen='true' id='wcframable1-1' style='width: 100%; height: 501px;' class='data-iframe-viewed'></iframe></div> <table cellspacing='0' class='wc-gallery-table wc-image-gallery-table' style='display:none;'> <tbody><tr class='wc-first-row wc-last-row'> <td class='wc-first-column wc-last-column wc-image-gallery-table'> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label='Black Stainless Enlarge Image'><img alt='' data-asset-title='Black Stainless' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/0326d6065b924a8783c7beba0d3574e0.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='5' data-height='90' data-index-in-collection='0' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/0326d6065b924a8783c7beba0d3574e0.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/0326d6065b924a8783c7beba0d3574e0.jpg.w1920.jpg' wcobj-height='500' wcobj-type='image/*' wcobj-width='480' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label='Black Slate Enlarge Image'><img alt='' data-asset-title='Black Slate' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/3c86d21714d54f288b973a3429bb3e48.webp?xml}' data-asset-wrapper='image-gallery' data-collection-size='5' data-height='90' data-index-in-collection='1' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/3c86d21714d54f288b973a3429bb3e48.webp.w240.webp' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/3c86d21714d54f288b973a3429bb3e48.webp.w1920.webp' wcobj-height='500' wcobj-type='image/*' wcobj-width='480' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label='White Enlarge Image'><img alt='' data-asset-title='White' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/c70b135a2e1b445bb6e3f4bdcc352a5a.webp?xml}' data-asset-wrapper='image-gallery' data-collection-size='5' data-height='90' data-index-in-collection='2' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/c70b135a2e1b445bb6e3f4bdcc352a5a.webp.w240.webp' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/c70b135a2e1b445bb6e3f4bdcc352a5a.webp.w1920.webp' wcobj-height='500' wcobj-type='image/*' wcobj-width='480' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label='Slate Enlarge Image'><img alt='' data-asset-title='Slate' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/c2dfe9a269bf4b3babbc222079914b96.webp?xml}' data-asset-wrapper='image-gallery' data-collection-size='5' data-height='90' data-index-in-collection='3' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/c2dfe9a269bf4b3babbc222079914b96.webp.w240.webp' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/c2dfe9a269bf4b3babbc222079914b96.webp.w1920.webp' wcobj-height='500' wcobj-type='image/*' wcobj-width='480' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> <div class='wc-gallery-thumb' style='width: 120px !important;'> <div style='width: 120px !important;height: 90px !important;position:relative!important;' class='wchs'><div style='width: 120px !important;height: 90px !important;' class='wc-thumb-image'><a href='javascript:void(0);' style='display: block !important;' aria-label='Black Enlarge Image'><img alt='' data-asset-title='Black' data-asset-type='image' data-asset-url='/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/1f393fe573be46b5ae95ae47b40cc4f1.jpg?xml}' data-asset-wrapper='image-gallery' data-collection-size='5' data-height='90' data-index-in-collection='4' data-width='120' height='250' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/1f393fe573be46b5ae95ae47b40cc4f1.jpg.w240.jpg' style='height: 125px !important; width:120px !important;margin-top: -18px !important;border:0 !important;' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-2094881d-9b63-0e91-88ce-388fb51f4ec3/1f393fe573be46b5ae95ae47b40cc4f1.jpg.w1920.jpg' wcobj-height='500' wcobj-type='image/*' wcobj-width='480' wcpc='1589815370307' width='240'></a></div><div class='wc-enlage-image' style='position:absolute!important;left:5px;bottom:5px;width:24px!important;height:24px!important;overflow:hidden!important'><img alt='' src='https://scontent.webcollage.net/apps/pp/assets/costco/images/image-gallery/enlarge.png'></div></div> </div> </td> </tr> </tbody></table> </span></div><div class='wc-clear-both' style='height: 0px !important'></div></div><div class='wc-fragment wc-no-focus' data-channel-product-name='' data-compiler-v='2020.7.2.487' data-cpi='100421002' data-gtin='00084691853824' data-is-capdesc-open='false' data-language-code='en' data-module-brand='ecg-13848' data-module-code='qejiqloxmqmjysdroceqxbdsl' data-module-name='ecg-13848' data-mpn='GNE27EYMFS' data-produced='2020-05-22 16:01' data-section-caption='Documents' data-section-tag='docs' data-section-template-code='document-gallery' data-vendor-name='27.0 Cu. Ft. Fingerprint Resistant French-Door Refrigerator' data-wcpc='1589815370307' id='wc-docs-b8f55645dbef0d9727872256617ff62e' data-is-reported-view='true'><h2>Documents</h2><div class='wc-aplus-body'><ul class='wc-document-gallery'> <li class='wc-doc-wrapper'> <h3 class='wc-doc-title-above'>Energy Guide</h3> <button class='wc-document-view-link wc-document-view-link-with-image wc-doc-thumb' tabindex='0' type='button'> <img alt='View Energy Guide PDF' data-asset-title='Energy Guide' data-asset-type='document' data-asset-url='/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/0d4db092a8d443fda1fb027f63781987.pdf' data-asset-wrapper='document-gallery' data-collection-size='4' data-index-in-collection='0' data-section-template-code='document-gallery' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_default_thumb_pp.png?v=2020.7.2.487' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/0d4db092a8d443fda1fb027f63781987.pdf' wcobj-type='application/pdf' wcpc='1589815370307'> </button> <div class='wc-doc-text'> <div><h3 class='wc-doc-title'>Energy Guide</h3> <div class='wc-document-description'></div> <div> <button class='wc-document-view-link' type='button'> View<span class='wc-screen-reader-only'> Energy Guide PDF</span> </button> <span class='wc-separator'>|</span> <a class='wc-document-download-link' href='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/0d4db092a8d443fda1fb027f63781987.pdf?action=download-resource&amp;caption=Energy%20Guide&amp;a=d' rel='nofollow' role='link'>Download<span class='wc-screen-reader-only'> Energy Guide PDF</span> </a> </div> <div> <img alt='' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_icon_pp.png?v=2020.7.2.487'> <small>PDF, 289K, <span>1 page</span></small> </div> </div> </div> </li> <li class='wc-doc-wrapper'> <h3 class='wc-doc-title-above'>Use and Care Manual</h3> <button class='wc-document-view-link wc-document-view-link-with-image wc-doc-thumb' tabindex='0' type='button'> <img alt='View Use and Care Manual PDF' data-asset-title='Use and Care Manual' data-asset-type='document' data-asset-url='/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/acb5c8bbf3564edabd12f27921deb5a4.pdf' data-asset-wrapper='document-gallery' data-collection-size='4' data-index-in-collection='1' data-section-template-code='document-gallery' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_default_thumb_pp.png?v=2020.7.2.487' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/acb5c8bbf3564edabd12f27921deb5a4.pdf' wcobj-type='application/pdf' wcpc='1589815370307'> </button> <div class='wc-doc-text'> <div><h3 class='wc-doc-title'>Use and Care Manual</h3> <div class='wc-document-description'></div> <div> <button class='wc-document-view-link' type='button'> View<span class='wc-screen-reader-only'> Use and Care Manual PDF</span> </button> <span class='wc-separator'>|</span> <a class='wc-document-download-link' href='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/acb5c8bbf3564edabd12f27921deb5a4.pdf?action=download-resource&amp;caption=Use%20and%20Care%20Manual&amp;a=d' rel='nofollow' role='link'>Download<span class='wc-screen-reader-only'> Use and Care Manual PDF</span> </a> </div> <div> <img alt='' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_icon_pp.png?v=2020.7.2.487'> <small>PDF, 18.7MB, <span>140 pages</span></small> </div> </div> </div> </li> <li class='wc-doc-wrapper wc-doc-pair'> <h3 class='wc-doc-title-above'>Spec</h3> <button class='wc-document-view-link wc-document-view-link-with-image wc-doc-thumb' tabindex='0' type='button'> <img alt='View Spec PDF' data-asset-title='Spec' data-asset-type='document' data-asset-url='/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/d9aedc188a5f4871be390b79b76d64d5.pdf' data-asset-wrapper='document-gallery' data-collection-size='4' data-index-in-collection='2' data-section-template-code='document-gallery' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_default_thumb_pp.png?v=2020.7.2.487' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/d9aedc188a5f4871be390b79b76d64d5.pdf' wcobj-type='application/pdf' wcpc='1589815370307'> </button> <div class='wc-doc-text'> <div><h3 class='wc-doc-title'>Spec</h3> <div class='wc-document-description'></div> <div> <button class='wc-document-view-link' type='button'> View<span class='wc-screen-reader-only'> Spec PDF</span> </button> <span class='wc-separator'>|</span> <a class='wc-document-download-link' href='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/d9aedc188a5f4871be390b79b76d64d5.pdf?action=download-resource&amp;caption=Spec&amp;a=d' rel='nofollow' role='link'>Download<span class='wc-screen-reader-only'> Spec PDF</span> </a> </div> <div> <img alt='' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_icon_pp.png?v=2020.7.2.487'> <small>PDF, 232K, <span>2 pages</span></small> </div> </div> </div> </li> <li class='wc-doc-wrapper wc-doc-trio'> <h3 class='wc-doc-title-above'>Prop 65</h3> <button class='wc-document-view-link wc-document-view-link-with-image wc-doc-thumb' tabindex='0' type='button'> <img alt='View Prop 65 PDF' data-asset-title='Prop 65' data-asset-type='document' data-asset-url='/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/a307bd951b07492aacc977f5f93725eb.pdf' data-asset-wrapper='document-gallery' data-collection-size='4' data-index-in-collection='3' data-section-template-code='document-gallery' module-id='qejiqloxmqmjysdroceqxbdsl' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_default_thumb_pp.png?v=2020.7.2.487' wcobj='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/a307bd951b07492aacc977f5f93725eb.pdf' wcobj-type='application/pdf' wcpc='1589815370307'> </button> <div class='wc-doc-text'> <div><h3 class='wc-doc-title'>Prop 65</h3> <div class='wc-document-description'></div> <div> <button class='wc-document-view-link' type='button'> View<span class='wc-screen-reader-only'> Prop 65 PDF</span> </button> <span class='wc-separator'>|</span> <a class='wc-document-download-link' href='https://smedia.webcollage.net/rwvfp/wc/cp/1589815395563_d075a2d7-87b2-4662-bb53-ce1e4682dee5/module/qejiqloxmqmjysdroceqxbdsl/_cp/products/1589815370307/tab-b8f55645-dbef-0d97-2787-2256617ff62e/a307bd951b07492aacc977f5f93725eb.pdf?action=download-resource&amp;caption=Prop%2065&amp;a=d' rel='nofollow' role='link'>Download<span class='wc-screen-reader-only'> Prop 65 PDF</span> </a> </div> <div> <img alt='' src='https://scontent.webcollage.net/_wc/default-defs/resources/document-gallery/v3/pdf_icon_pp.png?v=2020.7.2.487'> <small>PDF, 364K, <span>1 page</span></small> </div> </div> </div> </li> </ul></div><div class='wc-clear-both' style='height: 0px !important'></div></div><div class='wc-fragment wc-no-focus' data-channel-product-name='' data-compiler-v='2020.7.2.487' data-cpi='100421002' data-gtin='00084691853824' data-is-capdesc-open='false' data-language-code='en' data-module-brand='ecg-13848' data-module-code='qejiqloxmqmjysdroceqxbdsl' data-module-name='ecg-13848' data-mpn='GNE27EYMFS' data-produced='2020-05-22 16:01' data-section-caption='Spec' data-section-tag='specs' data-section-template-code='specifications' data-vendor-name='27.0 Cu. Ft. Fingerprint Resistant French-Door Refrigerator' data-wcpc='1589815370307' id='wc-specs-ee5a1a5c11de1167eb46085513a01448' data-is-reported-view='true'><h2>Spec</h2><div class='wc-aplus-body'><div class='wc-spec-cols-2 wc-specifications-responsive' style='visibility: visible !important;  width: 915px !important; '> <table cellpadding='0' cellspacing='0' class='wc-specifications-table' summary='Product specifications data table.'> <colgroup> <col class='wc-spec-caption'> <col class='wc-spec-data' data-column-index='1'> </colgroup> <tbody> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='1'> <th aria-label='' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-0'> <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'></div></div></th> </tr> <tr class='wc-odd-row first-group-row' data-index-row='1'> <th aria-label='Temperature Management Features' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-1' scope='col'> <span class='wc-reset'><span class='wc-markup-rich-text'>Temperature Management Features</span></span> </th> <th aria-label='Multiflow Air System with Electronic Sensors Turbo Cool setting' class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-1' scope='col'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Multiflow Air System with Electronic Sensors<br>Turbo Cool setting</span></span> </div> </th> </tr> <tr class='wc-even-row' data-index-row='1'> <th aria-label='Dispenser Features' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-2' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Dispenser Features</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-2'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>LED Dispenser Light<br>Water Filter Indicator Light</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='1'> <th aria-label='Control Type' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-3' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Control Type</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-3'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Digital Temperature Display<br>External Electronic Temperature Controls</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='1'> <th aria-label='Icemaker' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-4' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Icemaker</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-4'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Factory Installed</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='1'> <th aria-label='Performance Features' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-5' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Performance Features</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-5'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Easily Removable Door Gaskets</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='1'> <th aria-label='Door Alarm' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-6' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Door Alarm</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-6'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Yes</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='1'> <th aria-label='Freezer Storage Baskets' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-7' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Freezer Storage Baskets</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-7'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>1 Full-Width, Full-Extension Plastic<br>2 Total</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='1'> <th aria-label='Freezer Features' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-8' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Freezer Features</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-8'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Interior Lighting - LED</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='1'> <th aria-label='Exterior Style' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-9' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Exterior Style</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-9'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Free-Standing</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='1'> <th aria-label='Leveling System' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-10' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Leveling System</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-10'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>2 Point Front Adjustable</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='1'> <th aria-label='Performance Features' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-11' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Performance Features</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-11'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Easily Removable Door Gaskets</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='1'> <th aria-label='Door Liner' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-12' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Door Liner</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-12'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>HIPS</span></span> </div> </td> </tr> <tr class='wc-odd-row last-group-row' data-index-row='1'> <th aria-label='Product Type' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-13' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Product Type</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-0 wcr-sp-lkzd3j-feat-13'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Bottom Freezer Refrigerator<br>French-Door Refrigerator</span></span> </div> </td> </tr> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='2'> <th aria-label='CAPACITY' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-1'>  <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'><span class='wc-reset'><span class='wc-markup-rich-text'>CAPACITY</span></span></div></div></th> </tr> <tr class='wc-odd-row first-group-row' data-index-row='2'> <th aria-label='Total Capacity (cubic feet)' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-15' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Total Capacity (cubic feet)</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-1 wcr-sp-lkzd3j-feat-15'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>25.600000</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='2'> <th aria-label='Fresh Food Capacity' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-16' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Fresh Food Capacity</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-1 wcr-sp-lkzd3j-feat-16'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>17.46</span></span> </div> </td> </tr> <tr class='wc-odd-row last-group-row' data-index-row='2'> <th aria-label='Freezer Capacity' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-17' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Freezer Capacity</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-1 wcr-sp-lkzd3j-feat-17'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>8.18</span></span> </div> </td> </tr> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='3'> <th aria-label='APPEARANCE' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-2'>  <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'><span class='wc-reset'><span class='wc-markup-rich-text'>APPEARANCE</span></span></div></div></th> </tr> <tr class='wc-odd-row first-group-row' data-index-row='3'> <th aria-label='Color Appearance' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-19' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Color Appearance</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-19'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>High-Gloss White</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='3'> <th aria-label='Door Stops' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-20' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Door Stops</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-20'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Yes</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='3'> <th aria-label='Door Swing' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-21' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Door Swing</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-21'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Hinges on Left &amp; Right</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='3'> <th aria-label='Exterior Design' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-22' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Exterior Design</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-22'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Contoured Crown Doors<br>Hidden Door Hinges</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='3'> <th aria-label='Handle Color' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-23' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Handle Color</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-23'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Color-Matched</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='3'> <th aria-label='Handle Design' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-24' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Handle Design</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-24'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Designer Style</span></span> </div> </td> </tr> <tr class='wc-odd-row last-group-row' data-index-row='3'> <th aria-label='Textured Steel Case' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-25' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Textured Steel Case</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-2 wcr-sp-lkzd3j-feat-25'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>White</span></span> </div> </td> </tr> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='4'> <th aria-label='WEIGHTS &amp; DIMENSIONS' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-3'>  <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'><span class='wc-reset'><span class='wc-markup-rich-text'>WEIGHTS &amp; DIMENSIONS</span></span></div></div></th> </tr> <tr class='wc-odd-row first-group-row' data-index-row='4'> <th aria-label='Height to Top of Hinge' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-27' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Height to Top of Hinge</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-27'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>69 3/4</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='4'> <th aria-label='Approximate Shipping Weight' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-28' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Approximate Shipping Weight</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-28'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>303</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='4'> <th aria-label='Net Weight' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-29' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Net Weight</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-29'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>278</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='4'> <th aria-label='Overall Depth' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-30' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Overall Depth</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-30'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>35 7/8</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='4'> <th aria-label='Overall Height' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-31' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Overall Height</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-31'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>69 7/8</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='4'> <th aria-label='Overall Width' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-32' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Overall Width</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-32'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>35 3/4</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='4'> <th aria-label='Case Depth Without Door' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-33' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Case Depth Without Door</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-33'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>29</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='4'> <th aria-label='Depth with Door Open 90°' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-34' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Depth with Door Open 90°</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-34'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>48 3/8</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='4'> <th aria-label='Depth Without Handle' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-35' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Depth Without Handle</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-35'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>33 3/8</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='4'> <th aria-label='Height to Top of Case' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-36' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Height to Top of Case</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-36'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>68 5/8</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='4'> <th aria-label='Width w/Door Open 90 Degrees Incl. Handle' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-37' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Width w/Door Open 90 Degrees Incl. Handle</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-37'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>43 3/4</span></span> </div> </td> </tr> <tr class='wc-even-row' data-index-row='4'> <th aria-label='Back Air Clearances' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-38' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Back Air Clearances</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-38'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>2</span></span> </div> </td> </tr> <tr class='wc-odd-row' data-index-row='4'> <th aria-label='Side Air Clearances' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-39' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Side Air Clearances</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-39'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>0 1/8</span></span> </div> </td> </tr> <tr class='wc-even-row last-group-row' data-index-row='4'> <th aria-label='Top Air Clearances' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-40' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Top Air Clearances</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-3 wcr-sp-lkzd3j-feat-40'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>1</span></span> </div> </td> </tr> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='5'> <th aria-label='POWER / RATINGS' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-4'>  <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'><span class='wc-reset'><span class='wc-markup-rich-text'>POWER / RATINGS</span></span></div></div></th> </tr> <tr class='wc-odd-row first-group-row last-group-row' data-index-row='5'> <th aria-label='Volts/Hertz/Amps' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-42' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Volts/Hertz/Amps</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-4 wcr-sp-lkzd3j-feat-42'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>120v; 60Hz; 15A</span></span> </div> </td> </tr> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='6'> <th aria-label='WARRANTY' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-5'>  <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'><span class='wc-reset'><span class='wc-markup-rich-text'>WARRANTY</span></span></div></div></th> </tr> <tr class='wc-odd-row first-group-row' data-index-row='6'> <th aria-label='Parts Warranty' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-44' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Parts Warranty</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-5 wcr-sp-lkzd3j-feat-44'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Limited 1-year entire appliance</span></span> </div> </td> </tr> <tr class='wc-even-row last-group-row' data-index-row='6'> <th aria-label='Labor Warranty' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-45' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Labor Warranty</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-5 wcr-sp-lkzd3j-feat-45'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>Limited 1-year entire appliance</span></span> </div> </td> </tr> <tr class='wc-spec-header-row' role='button' tabindex='0' data-index-header-row='7'> <th aria-label='CERTIFICATIONS' class='wc-spec-caption' colspan='2' id='wcr-sp-lkzd3j-head-6'>  <div class='wc-headerContainer' aria-live='polite'><span class='wc-screen-reader-only'>Collapse group heading</span><i class='icon-toggle-up'></i><div class='wc-textContainer'><span class='wc-reset'><span class='wc-markup-rich-text'>CERTIFICATIONS</span></span></div></div></th> </tr> <tr class='wc-odd-row wc-last-row first-group-row' data-index-row='7'> <th aria-label='Claims &amp; Certifications' class='wc-spec-caption' id='wcr-sp-lkzd3j-feat-47' scope='row'> <span class='wc-reset'><span class='wc-markup-rich-text'>Claims &amp; Certifications</span></span> </th> <td class='wc-spec-data' headers='wcr-sp-lkzd3j-head-6 wcr-sp-lkzd3j-feat-47'> <div class='wc-cell-container'> <span class='wc-reset'><span class='wc-markup-rich-text'>ADA Compliant<br>ENERGY STAR® Qualified<br>California Prop 65</span></span> </div> </td> </tr> </tbody> </table> </div></div><div class='wc-clear-both' style='height: 0px !important'></div></div><div id='wc-fragment-terminator' style='width: 100% !important; clear: both !important; height: 0px !important;'></div></div></div>
                        <figure class='product-manuals visible-xs-block visible-sm-block visible-md-block'>
                        <h3>Manuals, Information &amp; Guides</h3>
                        <ul class='list-group product-attachments'>
                        <li class='list-group-item'><a href='/wcsstore/CostcoUSBCCatalogAssetStore/Attachment/GE+Warranty-5_5_17.pdf' class='pdf-link' target='_blank'><img class='pdf' src='/wcsstore/CostcoGLOBALSAS/images/pdf.svg' alt='PDF format'>
                        Warranty Information</a></li><li class='list-group-item'><a href='/wcsstore/CostcoUSBCCatalogAssetStore/Attachment/1202695GEApplianceHomeDeliveryGuidelines.PDF' class='pdf-link' target='_blank'><img class='pdf' src='/wcsstore/CostcoGLOBALSAS/images/pdf.svg' alt='PDF format'>GE Appliance Home Delivery Guidelines</a></li>
                        <li class='list-group-item'><a href='/wcsstore/CostcoUSBCCatalogAssetStore/Attachment/1259272_Spec.pdf' class='pdf-link' target='_blank'><img class='pdf' src='/wcsstore/CostcoGLOBALSAS/images/pdf.svg' alt='PDF format'>
                        Refrigerator Specifications</a></li></ul></figure></div>   </div></div>",
                    this,
                    new List<string> { "content/appliances/fridge-c45bedda-ccae-4078-ae48-c8bf0ba21802.jpg" }
                );

            LaptopNotebookComputer laptop = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)2099.99,
                    0,
                    (MarkupString)@"<div class='product - info - description' style='max - height: none; '>

                                   < span style = 'font-weight:bold;' > Limit 2 Per Member</ span >< br >< br >< span style = 'font-weight:bold;' > Processor & amp; Memory:</ span >< br >< ul >< li > 10th Gen Intel® Core™ i7 - 1065G7 Processor at 1.3GHz </ li >< li > 12GB DDR4-2666 SDRAM </ li >< br ></ ul >< span style = 'font-weight:bold;' > Drives: </ span >< br >< ul >< li > 512GB PCle® NVMe™ M.2 Solid State Drive </ li >< li > No Optical Drive</ li >< br ></ ul >< span style = 'font-weight:bold;' > Operating System: </ span >< br >< ul >< li > Microsoft® Windows 10 Home(64 - bit) </ li >< br ></ ul >< span style = 'font-weight:bold;' > Communications: </ span >< br >< ul >< li > 802.11 Wireless - AC WLAN(1x1) + Bluetooth® 4.2 </ li >< li > HP TrueVision HD Webcam + Integrated Dual Array Digital Microphones</ li >< br ></ ul >< span style = 'font-weight:bold;' > Graphics & amp; Video:</ span > < br >< ul >< li > 14' IPS Anti-Glare WLED-backlit FHD (1920 x 1080) Display</li><li>Integrated Intel® Iris™ Plus Graphics</li><br></ul><span style='font - weight:bold; '>Audio: </span><br><ul><li>HP HD Audio with Stereo Speakers</li><br></ul><span style='font - weight:bold; '>Keyboard: </span><br><ul><li>Full-size Island-style Backlit Keyboard</li><li>HP Imagepad with Multi-Touch Gesture Support</li><br></ul><span style='font - weight:bold; '>Ports: </span><br><ul><li>1x USB 3.1 Gen 1 Type-C </li><li>2x USB 3.1 Gen 1 Type-A</li><li>1x HDMI 1.4b</li><li>1x AC Smart Pin</li><li>1x Combination Headphone/Microphone Jack</li><li>1x Multi-Format SD Media Card Reader </li><br></ul><span style='font - weight:bold; '>Power Supply: </span><br><ul><li>3-Cell 41WHr Lithium-Ion Battery &nbsp;</li><br></ul><span style='font - weight:bold; '>Additional Information: </span><br><ul><li>Dimensions: 12.76' x 8.86' x 0.71' </ li >< li > Approximate Weight: 3.24 lbs </ li ></ ul >
                                                                                                                                                               

                                                                                                                                                                               </ div > ",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop1 = new LaptopNotebookComputer
                (
                    "Apple MacBook Pro 16\" with Touch Bar - Intel Core i7 - 16GB Memory - 512GB SSD",
                    (decimal)2099.99,
                    45,
                    (MarkupString)@"<div class='product - info - description' style='max - height: none; '>

                                   < div style = 'text-align:center;' >< span style = 'font-weight:bold;' > Item may be available in your local warehouse, prices may vary.</ span ></ div >< br >< span style = 'font-weight:bold;' > Limit 2 Per Member</ span >< br >< br >< span style = 'font-weight:bold;' > Processor & amp; Memory:</ span >< br >< ul >< li > 9th Gen 6 - core Intel® Core™ i7 Processor 2.6GHz </ li >< li > 16GB 2666MHz DDR4 RAM </ li >< br ></ ul >< span style = 'font-weight:bold;' > Drives: </ span >< br >< ul >< li > 512GB PCIe Solid State Drive </ li >< li > No Optical Drive</ li >< br ></ ul >< span style = 'font-weight:bold;' > Operating System: </ span >< br >< ul >< li > macOS </ li >< br ></ ul >< span style = 'font-weight:bold;' > Communications: </ span >< br >< ul >< li > 802.11 Wireless - AC + Bluetooth 5.0 </ li >< li > Integrated 720p FaceTime HD Camera</ li >< br ></ ul >< span style = 'font-weight:bold;' > Audio:</ span >< br >< ul >< li > 6 Speaker System with Force-Cancelling Woofers </ li >< br ></ ul >< span style = 'font-weight:bold;' > Graphics & amp; Video: </ span >< br >< ul >< li > 16' LED-Backlit (3072 x 1920) Retina Display with True Tone</li><li>4GB AMD Radeon Pro 5300M Graphics</li><br></ul><span style='font - weight:bold; '>Keyboard: </span><br><ul><li>Full-Size Backlit Magic Keyboard</li><li>Integrated Touch ID Sensor </li><li>Ambient Light Sensor</li><br></ul><span style='font - weight:bold; '>Ports &amp; Slots: </span><br><ul><li>4x Thunderbolt 3 USB-C (Charging and DisplayPort)</li><li>1x Headphone Jack</li><br></ul><span style='font - weight:bold; '>Power Supply: </span><br><ul><li>100WHr Battery</li><br></ul><span style='font - weight:bold; '>Additional Information: </span><br><ul><li>Dimensions: 14.09' x 9.68' x 0.64' </ li >< li > Approximate Weight: Starting at 4.3lbs </ li ></ ul >
                                                                                                                                                                                               

                                                                                                                                                                                                               </ div > ",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Gold,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop2 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/bbbb.png" },
                    Color.Silver,
                    new List<string> { "Bluetooth 4.1" },
                    "Warehouse Pick-up",
                    "1366 x 768 (HD)",
                    "Intel Iris Plus",
                    "Acer",
                    "All-in-One",
                    "128 GB",
                    "Chrome OS",
                    "AMD Ryzen 5",
                    "12 in.",
                    "Touchscreen"
                );
            LaptopNotebookComputer laptop3 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop4 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop5 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop6 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop7 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop8 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop9 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop10 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop11 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop12 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop13 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop14 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop15 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop16 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop17 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop18 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop19 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop20 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop21 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop22 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop23 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop24 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop25 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop26 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop27 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop28 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop29 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop30 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop31 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop32 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop33 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop34 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop35 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop36 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop37 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop38 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop39 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop40 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop41 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop42 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop43 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop44 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop45 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop46 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop47 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop48 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop49 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop50 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop51 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop52 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop53 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop54 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop55 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop56 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop57 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop58 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop59 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop60 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop61 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop62 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop63 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop64 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop65 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop66 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop67 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop68 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop69 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop70 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop71 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop72 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop73 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop74 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop75 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop76 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop77 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop78 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop79 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
             LaptopNotebookComputer laptop80 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop81 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop82 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop83 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop84 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop85 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop86 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop87 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop88 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop89 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop90 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop91 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop92 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Non-touchscreen"
                );
            LaptopNotebookComputer laptop93 = new LaptopNotebookComputer
                (
                    "HP 14\" Laptop - 10th Gen Intel Core i7 - 1065G7 - 1080p",
                    (decimal)150,
                    0,
                    (MarkupString)"",
                    this,
                    new List<string> { "content/products/computers/laptopNotebookComputers/aaaa.png" },
                    Color.Black,
                    new List<string> { "Backlit Keyboard" },
                    "Warehouse Pick-up",
                    "1920 x 1080 (Full HD)",
                    "Integrated Graphics",
                    "HP",
                    "2-in-1",
                    "64 GB",
                    "Windows OS",
                    "Intel Core i3",
                    "11.6 in.",
                    "Touchscreen"
                );
        }

        

        

        
    }
}

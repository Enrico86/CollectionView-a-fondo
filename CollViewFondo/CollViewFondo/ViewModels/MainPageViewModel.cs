using CollViewFondo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollViewFondo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private bool isRefreshing;
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get => products; 
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        public ICommand Favorite_Command { get; set; }
        public ICommand Delete_Command { get; set; }
        public ICommand Refresh_Command { get; set; }

        public ICommand ThresholdReachedCommand { get; set; }
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<ProductGroup> ProductsGroupedList { get; set; }
        public MainPageViewModel()
        {
            Products = new ObservableCollection<Product>();
            RefreshItems();
            Delete_Command = new Command((item) =>
            {
                Products.Remove((Product)item);
            });
            Favorite_Command = new Command((item) =>
            {
            });
            Refresh_Command = new Command(async () =>
            {
                IsRefreshing = true;
                await Task.Delay(2000);
                RefreshItems();
                IsRefreshing = false;
            });
            ThresholdReachedCommand = new Command(() =>
            {
                RefreshItems(Products.Count);
            });
        }

        private void RefreshItems(int lastIndex = 0)
        {
            int numberOfItemsPerPage = 0; 
            var items = new List<Product>
            {
                new Product
                {
                    Name = "Yogurt",
                    Price = 0.60m,
                    Image = "yogurt.png",
                    HasOffer = false,
                },
                new Product
                {
                    Name = "Watermelon",
                    Price = 0.95m,
                    Image = "watermelon.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Water Bottle",
                    Price = 0.25m,
                    Image = "water_bottle.png",
                    HasOffer = true,
                    Discount = 15
                },
                new Product
                {
                    Name = "Tomato",
                    Price = 1.20m,
                    Image = "tomato.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Tea",
                    Price = 0.65m,
                    Image = "tea_bag.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Sparkling Drink",
                    Price = 0.35m,
                    Image = "sparkling_drink.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Spaguetti",
                    Price = 1.50m,
                    Image = "spaguetti.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Cream",
                    Price = 1.28m,
                    Image = "cream.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Snack",
                    Price = 1.25m,
                    Image = "snack.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Shrimp",
                    Price = 3.50m,
                    Image = "shrimp.png",
                    HasOffer = true,
                    Discount = 25
                },
                new Product
                {
                    Name = "Seasoning",
                    Price = 1.85m,
                    Image = "seasoning.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Sauce",
                    Price = 2.20m,
                    Image = "sauce.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Rice",
                    Price = 0.98m,
                    Image = "rice.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Peas",
                    Price = 1.14m,
                    Image = "peas.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Ham",
                    Price = 2.95m,
                    Image = "ham_1.png",
                    HasOffer = true,
                    Discount = 10
                },
                new Product
                {
                    Name = "Chicken Leg",
                    Price = 6.95m,
                    Image = "chicken_leg.png",
                    HasOffer = true,
                    Discount = 30
                },
                new Product
                {
                    Name = "Pizza",
                    Price = 3.95m,
                    Image = "pizza.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Pineapple",
                    Price = 1.49m,
                    Image = "pineapple.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Pepper",
                    Price = 1.60m,
                    Image = "pepper.png",
                    HasOffer = true,
                    Discount = 15
                },
                new Product
                {
                    Name = "Pasta",
                    Price = 0.95m,
                    Image = "pasta.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Oil Bottle",
                    Price = 7.50m,
                    Image = "oil_bottle",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Mushroom",
                    Price = 1.25m,
                    Image = "mushroom.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Milk Bottle",
                    Price = 0.85m,
                    Image = "milk_bottle.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Meat",
                    Price = 9.50m,
                    Image = "meat.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Lemon",
                    Price = 0.82m,
                    Image = "lemon.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Tomato Sauce",
                    Price = 1.05m,
                    Image = "tomato_sauce.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Juice",
                    Price = 0.60m,
                    Image = "juice.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Ice Cream",
                    Price = 2.51m,
                    Image = "ice_cream.png",
                    HasOffer = true,
                    Discount= 20
                },
                new Product
                {
                    Name = "Ham",
                    Price = 2.90m,
                    Image = "ham.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Ice",
                    Price = 1.25m,
                    Image = "ice.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Flour",
                    Price = 0.86m,
                    Image = "flour.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Fish",
                    Price = 4.40m,
                    Image = "fish_1.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Fish 2",
                    Price = 4.25m,
                    Image = "fish.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Eggs",
                    Price = 1.50m,
                    Image = "eggs.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Cucumber",
                    Price = 0.35m,
                    Image = "cucumber.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Croissant",
                    Price = 0.68m,
                    Image = "croissant.png",
                    HasOffer = true,
                    Discount = 25
                },
                new Product
                {
                    Name = "Cookies",
                    Price = 0.95m,
                    Image = "cookie.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Coffee",
                    Price = 1.54m,
                    Image = "toffee.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Chocolate Bar",
                    Price = 3.2m,
                    Image = "chocolate_bar.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Cheese",
                    Price = 3.60m,
                    Image = "cheese.png",
                    HasOffer = true,
                    Discount = 20
                },
                new Product
                {
                    Name = "Carrot",
                    Price = 1.15m,
                    Image = "carrot.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Canned Food",
                    Price = 0.89m,
                    Image = "canned_food.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Soda",
                    Price = 0.45m,
                    Image = "can.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Candies",
                    Price = 1.55m,
                    Image = "candy.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Cake",
                    Price = 2.50m,
                    Image = "cake.png",
                    HasOffer = true,
                    Discount = 15
                },
                new Product
                {
                    Name = "Bread",
                    Price = 1.00m,
                    Image = "bread_1.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Bread",
                    Price = 0.85m,
                    Image = "bread.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Banana",
                    Price = 1.50m,
                    Image = "banana.png",
                    HasOffer = true,
                    Discount = 10
                },
                new Product
                {
                    Name = "Apple",
                    Price = 1.40m,
                    Image = "apple.png",
                    HasOffer = false
                },
                new Product
                {
                    Name = "Alcohol",
                    Price = 8.70m,
                    Image = "alcohol.png",
                    HasOffer = false
                },
            };
            var grouped = from i in items
                          orderby i.Name
                          group i by i.Name[0].ToString()
                          into groups
                          select new ProductGroup(groups.Key,groups.ToList());
            int id = 1;
            decimal offerPrice = 0;
            foreach (var group in grouped)
            {
                foreach (var item in group)
                {
                    item.ID = id;
                    id++;
                    offerPrice = item.Price * (item.Discount / 100);
                    item.OfferPrice = offerPrice;
                }
            }


            ProductsGroupedList = new ObservableCollection<ProductGroup>(grouped);
            ProductsGroupedList.Add(new ProductGroup("Empty DEMO", new List<Product>()));
            var itemsObs = new ObservableCollection<ProductGroup>(ProductsGroupedList);
            var pageItems = itemsObs.Skip(lastIndex).Take(numberOfItemsPerPage);
            foreach (var item in pageItems)
            {
                ProductsGroupedList.Add(item);
            }
        }
        
        public async Task GetData()
    
    }
}

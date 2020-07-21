using CollViewFondo.Models;
using CollViewFondo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollViewFondo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void collectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            Debug.WriteLine($"HorizontalDelta: {e.HorizontalDelta}");
            Debug.WriteLine($"VerticalDelta: {e.VerticalDelta}");
            Debug.WriteLine($"HorizontalOffset: {e.HorizontalOffset}");
            Debug.WriteLine($"VerticalOffset: {e.VerticalOffset}");
            Debug.WriteLine($"FirstVisibleItemIndex: {e.FirstVisibleItemIndex}");
            Debug.WriteLine($"CenterItemIndex: {e.CenterItemIndex}");
            Debug.WriteLine($"LastVisibleItemIndex: {e.LastVisibleItemIndex}");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //collectionView.ScrollTo(10);
            var viewModel = BindingContext as MainPageViewModel;
            viewModel.ProductsGroupedList.Add(new ProductGroup("New Group", new List<Product> 
            {
                new Product()
                {
                    ID=100,
                    Price=1000,
                    Name="ProductSample",
                    Discount=10,
                    HasOffer=true,
                    Image="trash.png",
                }
            }));
            var product = viewModel.ProductsGroupedList
                .SelectMany(p=>p)
                .FirstOrDefault(p=>p.ID==6);
            collectionView.ScrollTo(product,animate:false, position:ScrollToPosition.Start);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Skeleton;
using Xamarin.Forms.Xaml;

namespace CollViewFondo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerPage : ContentPage
    {
        public CustomerPageViewModel cpvm = new CustomerPageViewModel();
        public CustomerPage()
        {
            InitializeComponent();
            BindingContext = cpvm;
        }

        protected async override void OnAppearing()
        {
            cpvm.GetData();
        }

        private void ScrollButton_Clicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as CustomerPageViewModel;
            var customer = viewModel.Customers
                .SelectMany(c => c)
                .FirstOrDefault(i => i.Id == 10);
            collectionView.ScrollTo(customer, position:ScrollToPosition.Start);
        }
    }
}
using Bogus;
using CollViewFondo.Models;
using CollViewFondo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollViewFondo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage()
        {
            InitializeComponent();
            BindingContext = new PeoplePageViewModel();
        }

        //private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var element = e.CurrentSelection;
        //}

        //private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var itemSelected = e.CurrentSelection;
        //    var previousItemSelected = e.PreviousSelection;
        //}
    }
}
using CollViewFondo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollViewFondo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SquaresPage : ContentPage
    {
        public SquaresPage()
        {
            InitializeComponent();
            var colors = ColorsService.GetColors();
            BindingContext = new ObservableCollection<SquareColor>(colors);
        }
    }
}
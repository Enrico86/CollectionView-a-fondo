using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CollViewFondo.CustomTypes
{
    public class FilterData : BindableObject
    {
        public static readonly BindableProperty FilterProperty =
            BindableProperty.Create(nameof(Filter), typeof(string),
                typeof(FilterData), null);
        private string filter;

        public string Filter
        {
            get
            {
                return (string)GetValue(FilterProperty);
            }

            set
            {
                SetValue(FilterProperty, value);
            }
        }
    }
}

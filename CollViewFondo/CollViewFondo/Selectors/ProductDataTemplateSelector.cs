using CollViewFondo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CollViewFondo.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var collection = container as GroupableItemsView;
            if(container !=null)
            {
                var product = item as Product;
                if (product.HasOffer == true)
                {
                    return (DataTemplate)collection.Resources["productWithOffer"];
                }
                else
                {
                    return (DataTemplate)collection.Resources["product"];
                }
            }
            return null;
        }
    }
}

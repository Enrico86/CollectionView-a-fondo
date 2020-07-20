using CollViewFondo.CustomTypes;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CollViewFondo.Selectors
{
    public class SearchTermDataTemplateSelector : DataTemplateSelector
    {
        private DataTemplate defaultTemplate;
        private DataTemplate secondaryTemplate;

        public DataTemplate SecondaryTemplate
        {
            get { return secondaryTemplate; }
            set { secondaryTemplate = value; }
        }


        public DataTemplate DefaultTemplate
        {
            get { return defaultTemplate; }
            set { defaultTemplate = value; }
        }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            string query = ((FilterData)item).Filter;
            if (query.ToLower().Equals("xamarin"))
            {
                return DefaultTemplate;
            }
            else return SecondaryTemplate;

        }
    }
}

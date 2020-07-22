using CollViewFondo.Models;
using CollViewFondo.Services;
using CollViewFondo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Skeleton;

namespace CollViewFondo.Views
{
    public class CustomerPageViewModel : BaseViewModel
    {
        private ObservableCollection<CustomerGroup> customers;
        private bool isBusy;

        public ObservableCollection<CustomerGroup> Customers
        {
            get => customers;
            set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
        public CustomerPageViewModel()
        {
            Customers = new ObservableCollection<CustomerGroup>();
            var initialGroup = new CustomerGroup("", new List<Customer>());
            for (int i = 0; i < 10; i++)
            {
                initialGroup.Add(new Customer()
                {
                    Id = 0,
                    Name = "",
                    Email = ""
                });
            }
            Customers.Add(initialGroup);
        }

        public async Task GetData()
        {
            IsBusy = true;
            await Task.Delay(5000);
            var customers = CustomersService.GetCustomers();
            var grouped = from c in customers
                          orderby c.Name
                          group c by c.Name[0].ToString()
                          into groups
                          select new CustomerGroup(groups.Key, groups.ToList());
            int id = 1;
            foreach (var group in grouped)
            {
                foreach (var item in group)
                {
                    item.Id = id;
                    id++;
                }
            }
            Customers = new ObservableCollection<CustomerGroup>(grouped);
            IsBusy = false;
        }
    }
}

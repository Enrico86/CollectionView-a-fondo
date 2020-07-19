using CollViewFondo.Models;
using CollViewFondo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollViewFondo.ViewModels
{
    public class PeoplePageViewModel: BaseViewModel
    {
        private Person selectedPerson;
        private List<object> selectedPeople;

        public ObservableCollection<Person> People { get; set; }
        public List<Person> SelectedPeopleList { get; set; }
        public ICommand PersonChanged_Command { get; set; }
        public ICommand PeopleChanged_Command { get; set; }
        public ICommand ClearCommand { get; set; }
        public List<object> SelectedPeople
        {
            get => selectedPeople;
            set
            {
                selectedPeople = value;
                OnPropertyChanged();
            }
        }
        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
                OnPropertyChanged();
            }
        }


        public PeoplePageViewModel()
        {
            var people = PeopleService.GetPeople().OrderBy(x=>x.FirstName);
            People = new ObservableCollection<Person>(people);
            SelectedPeopleList = new List<Person>();
            SelectedPeople = new List<object>(people.Take(5));
            SelectedPerson = people.Skip(3).FirstOrDefault(n => n.FirstName.StartsWith("D"));

            PersonChanged_Command = new Command((item) =>
            {
                var person = SelectedPerson;
                var i = item as Person;
                SelectedPeopleList.Add(i);
            });

            PeopleChanged_Command = new Command((p) =>
            {
                var multipleSelection = p;

            });

            ClearCommand = new Command(() =>
            {
                SelectedPerson = null;
                SelectedPeople = null;
            });
        }

    }
}

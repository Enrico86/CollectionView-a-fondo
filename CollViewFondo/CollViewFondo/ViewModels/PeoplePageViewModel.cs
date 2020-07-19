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
    public class PeoplePageViewModel
    {
        private Person selectedPerson;
        private List<object> selectedPeople;

        public ObservableCollection<Person> People { get; set; }
        public List<Person> SelectedPeopleList { get; set; }
        public ICommand PersonChanged_Command { get; set; }
        public ICommand PeopleChanged_Command { get; set; }
        public List<object> SelectedPeople
        {
            get => selectedPeople;
            set
            {
                selectedPeople = value;
            }
        }
        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
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
        }

    }
}

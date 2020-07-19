
using Bogus;
using CollViewFondo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Person = CollViewFondo.Models.Person;

namespace CollViewFondo.Services
{
    public class PeopleService
    {

        public static List<Person> GetPeople()
        {
            var people = new Faker<Person>("es").RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.Address, f => f.Address.StreetAddress())
                .RuleFor(x => x.LastName, f => f.Name.LastName( ))
                .RuleFor(x => x.Age, f => f.Random.Number(1, 100))
                .Generate(50);
            return people.ToList();
        }
    }
}

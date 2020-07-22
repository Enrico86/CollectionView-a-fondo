using CollViewFondo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using Bogus.DataSets;
using System.Linq;

namespace CollViewFondo.Services
{
    public class CustomersService
    {
        public static List<Customer> GetCustomers ()
        {
            var customers = new Faker<Customer>("es").RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .Generate(50);
            return customers.ToList();
        }
    }
}

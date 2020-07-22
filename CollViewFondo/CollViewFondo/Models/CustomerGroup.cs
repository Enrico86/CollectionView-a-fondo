using System;
using System.Collections.Generic;
using System.Text;

namespace CollViewFondo.Models
{
    public class CustomerGroup: List<Customer>
    {
        public string GroupName { get; set; }

        public CustomerGroup(string _groupname, List<Customer> customers):base(customers)
        {
            GroupName = _groupname;
        }
    }
}

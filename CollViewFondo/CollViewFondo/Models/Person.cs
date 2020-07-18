using System;
using System.Collections.Generic;
using System.Text;

namespace CollViewFondo.Models
{
    public class Person
    {
        private string firstName;
        private int age;
        private string lastName;
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }



        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }



        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

    }
}

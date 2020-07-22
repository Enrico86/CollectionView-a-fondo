using CollViewFondo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollViewFondo.Models
{
    public class Customer: BaseViewModel
    {
        private string name;
        private string email;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}

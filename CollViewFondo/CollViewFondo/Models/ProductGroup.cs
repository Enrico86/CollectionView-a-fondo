using System;
using System.Collections.Generic;
using System.Text;

namespace CollViewFondo.Models
{
    public class ProductGroup: List<Product>
    {
        public string GroupName { get; set; }

        public ProductGroup(string _groupName, List<Product> products): base(products)
        {
            GroupName = _groupName;
        }

    }
}

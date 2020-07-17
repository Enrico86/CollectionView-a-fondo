using System;
using System.Collections.Generic;
using System.Text;

namespace CollViewFondo.Models
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private bool hasOffer;

        public bool HasOffer
        {
            get { return hasOffer; }
            set { hasOffer = value; }
        }

        private decimal offerPrice;

        public decimal OfferPrice
        {
            get { return offerPrice; }
            set { offerPrice = value; }
        }

        public Product()
        {
                OfferPrice = Price * (Discount / 100);
        }

    }
}

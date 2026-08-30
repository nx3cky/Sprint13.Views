using System;
using System.Collections.Generic;
using System.Text;

namespace vs.Models
{
    public class Product
    {
        public string _name { get; set; }
        public double _price { get; set; }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
    }
}

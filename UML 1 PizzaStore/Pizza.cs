using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1_PizzaStore
{
    class Pizza
    {
        private string _name;
        private int _price;

        public Pizza(string pizzaName, int pizzaPrice)
        {
            _name = pizzaName;
            _price = pizzaPrice;
        }
        public string PizzaName
        {
            get { return _name; }
        }
        public int PizzaPrice
        {
            get { return _price; }
        }


        public override string ToString()
        {
            return $"Pizza: {_name} Price: {_price}";
        }
    }
}
   
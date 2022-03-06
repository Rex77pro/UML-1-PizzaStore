using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1_PizzaStore
{
    class Order
    {
        private Customer _customer;
        private Pizza _pizza;

        private double _tax;
        private int _delivery;
        private double _totalPrice;
        private int _pizzaPrice;

        public Order(string customerName, string pizzaName, int pizzaPrice)
        {
            _customer = new Customer(customerName);
            _pizza = new Pizza(pizzaName, pizzaPrice);

            _tax = 1.05;
            _delivery = 40;
            _pizzaPrice = pizzaPrice;
        }

        public string Customer
        {
            get { return _customer.CustomerName; }
        }

        public string PizzaName
        {
            get { return _pizza.PizzaName; }
        }

        public int PizzaPrice
        {
            get { return _pizza.PizzaPrice; }
        }

        public double TotalPrice
        {
            get { return _totalPrice = CalculateTotalPrice(); }
        }

        public double CalculateTotalPrice()
        {
            _totalPrice = _pizzaPrice * _tax + _delivery;
            return _totalPrice;
        }

        public void PrintOrderInformation()
        {
            Console.WriteLine(_customer.ToString());
            Console.WriteLine(_pizza.ToString());
            Console.WriteLine($"{CalculateTotalPrice()} DKK");

            //$"Customer name: {_customer.CustomerName}, " +
            //$"Pizza name: {_pizza.PizzaName}, " +
            //$"Pizza price: {_pizza.PizzaPrice} " +
            //$"Total price (incl. tax and delivery): {CalculateTotalPrice()}";
        }
    }
} 

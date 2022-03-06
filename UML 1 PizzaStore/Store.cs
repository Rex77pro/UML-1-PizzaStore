using System;


namespace UML_1_PizzaStore
{
    class Store
    {
        public void MyCode()
        {
            //Customer c1 = new Customer("Maddie", 54660214);
            //Customer c2 = new Customer("Maria", 66770889);
            //Customer c3 = new Customer("Nicklas", 32481652);

            //Pizza p1 = new Pizza("Margherita", 50);
            //Pizza p2 = new Pizza("Hawaii", 65);
            //Pizza p3 = new Pizza("Pepperoni Feast", 70);

            //Totalprice order 1 = 91
            //Totalprice order 2 = 106,3
            //Totalprice order 3 = 111,4


            Order order1 = new Order("Maddie","Margherita", 50);
            Order order2 = new Order("Maria","Hawaii",65);
            Order order3 = new Order("Nicklas", "Pepperoni Feast", 70);

            Console.WriteLine();
            order1.PrintOrderInformation();
            Console.WriteLine();
            order2.PrintOrderInformation();
            Console.WriteLine();
            order3.PrintOrderInformation();
            
            
        }
    }
}

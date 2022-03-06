using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1_PizzaStore
{
    class Customer
    {
        #region Instance Field
        private string _name;

        #endregion

        #region Constructor
        public Customer(string name)
        {
            _name = name;
        }
        #endregion

        #region Properties
        public string CustomerName
        {
            get { return _name; }
        }

        #endregion    

        public override string ToString()
        {
            return $"Name: {_name}";
        }
        
    }
}

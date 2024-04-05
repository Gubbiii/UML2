using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Order // Order doesn't work!
    {
        private int _Id = 1;
        private static int _orderCounter = 1;
        Customer _customer;
      

        public Order(Pizza pizza, Customer customer)
        {
            Id = _orderCounter;
            _orderCounter++;
        }

        public int Id { get; set; }

        public Customer Customer
        {
            get { return _customer; }
            private set { _customer = value; }
        }


        public override string ToString()
        {
            return $"Order ID: {Id}";
        }
    }
}

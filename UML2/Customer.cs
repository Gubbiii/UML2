using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Customer
    {
        private int _id = 1;
        private static int customerCounter = 1;
        private string _name;
        private string _adress;
        private int _phoneNumber;

        public Customer(string name, string adress, int phoneNumber) //constructor
        {
            CustomerName = name;
            _adress = adress;
            _phoneNumber = phoneNumber;
            Id = customerCounter;
            customerCounter++;
        }

        public int Id { get; set; }

        public string CustomerName
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            private set { _adress = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            private set { _phoneNumber = value; }
        }




        public override string ToString()
        {
            return $"Customer name: {_name}, with phone number: {PhoneNumber} - delivery to adress: {Adress} Customer id: {Id}";
        }
    }
}

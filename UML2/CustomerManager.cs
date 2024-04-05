using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{

   
    public class CustomerManager
    {
        
        
        List<Customer> customers = new List<Customer>();

        public void CreateCustomer(Customer customer)
        {

            customers.Add(customer);
           

        }

      

        public string PrintCustomer()
        {
            string menu = "";
            foreach (Customer customer in customers)
            {
                menu += ($"Customer name: {customer.CustomerName}, Customer adress: {customer.Adress}, Customer phone number: {customer.PhoneNumber}, Customer id: {customer.Id}\n");

            }
            return menu;
        }

        public void RemoveCustomer(string name)
        {

            customers.RemoveAll(Customer => Customer.CustomerName == name);


        }

        public Customer CustomerSearch(string Name)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                bool customerExist = (customers[i].CustomerName == Name);

                if (customerExist)
                {
                    Console.WriteLine($"{customers[i]}");
                    return customers[i];
                }

            }
            return null;
        }

        
       
    }
}

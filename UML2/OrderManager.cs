using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML2
{
    public class OrderManager // Order doesn't work!
    {
    
        List<Order> orders = new List<Order>();

        public void CreateOrder(Pizza p1, Customer c1)
        {

            orders.Add(new Order(p1, c1));
            
        }



       
        /*public string PrintOrder()
        {
            string menu = "";
            foreach (Order orders in orders)
            {
                menu += $"{orders.ID}\n";

            }
            return menu;
        } */
        
    }
}

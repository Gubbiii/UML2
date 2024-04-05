using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML2
{
    public class MenuCatalog
    {
        


        public void PrintOptions()
        { 
            Console.WriteLine("You have the following options:" +
                "\n0: Quit" +
                "\n1: Add a new pizza" +
                "\n2: Delete a pizza" +
                "\n3: Update a pizza" +
                "\n4: Search for a pizza" +
                "\n5: Display the pizza menu" +
                "\n6: Create an order" +
                "\n7: Add a customer " +
                "\n8: Display the customers" +
                "\n9: Delete a customer" +
                "\n10: Display the order");

        }

        


    }
}


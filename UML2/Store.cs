using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML2
{
    internal class Store
    {
        static MenuCatalog _menuCatalogMgr = new MenuCatalog();
        static CustomerManager _customerMgr = new CustomerManager();
        static OrderManager _orderMgr = new OrderManager();
        static PizzaManager _pizzaMgr = new PizzaManager();

        public void Start()
        {

            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Big mamas Pizzaria |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Press enter to start the program");
            Console.ReadLine();
            Console.Clear();
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


            Console.Write("Option: ");
            int menuChoice = int.Parse(Console.ReadLine());
            UiMenu(menuChoice);

        }

        public static void UiMenu(int menuChoice)
        {

            switch (menuChoice)
            {
                case 0:
                    Console.Write("Goodbye");
                    Console.ReadLine();
                    
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("You have chosen to add a new pizza to the menu\nWhat is the name of the pizza?");
                    Console.WriteLine("Pizza name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Pizza price (min. 50 kr):");
                    int price = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Pizza id:");
                    int ID = int.Parse(Console.ReadLine());

                    _pizzaMgr.CreatePizza(new Pizza(name, price, ID));

                    Console.WriteLine($"Current pizzas:\n{_pizzaMgr.PrintMenu()}");
                    _menuCatalogMgr.PrintOptions();
                    int userchoice1 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice1);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("You have chosen to delete a pizza\nWrite the ID for the pizza you want to delete, please\nThis is your pizzas:");
                    Console.WriteLine(_pizzaMgr.PrintMenu());
                    int idValue = int.Parse(Console.ReadLine());
                    _pizzaMgr.RemovePizza(idValue);
                    Console.WriteLine($"This is your updated pizza list:\n{_pizzaMgr.PrintMenu()}");
                    _menuCatalogMgr.PrintOptions();
                    int userchoice2 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice2);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("You have chosen to update a pizza");
                    Console.WriteLine($"Which pizza would you like to update?\n{_pizzaMgr.PrintMenu()}\nWrite the pizza ID:");
                    int idValue2 = int.Parse(Console.ReadLine());
                    _pizzaMgr.RemovePizza(idValue2);
                    Console.WriteLine("Pizza name:");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Pizza price (min. 50 kr):");
                    int price2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Pizza id:");
                    int ID2 = int.Parse(Console.ReadLine());

                    _pizzaMgr.CreatePizza(new Pizza(name2, price2, ID2));
                    _pizzaMgr.PrintMenu();
                    _menuCatalogMgr.PrintOptions();
                    int userchoice3 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice3);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("You have chosen to search for a pizza\nPlease insert a pizza ID to search for:");
                    int IDSearch = int.Parse(Console.ReadLine());
                    Pizza p = _pizzaMgr.SearchPizza(IDSearch);
                    if (p != null)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.WriteLine("Pizza doesn't exist");
                    }
                    _menuCatalogMgr.PrintOptions();
                    int userchoice4 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice4);

                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("You have chosen to display the pizza menu\nPizza menu:");
                    Console.WriteLine(_pizzaMgr.PrintMenu());
                    _menuCatalogMgr.PrintOptions();
                    int userchoice5 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice5);
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("You have chosen to create an order!");
                    Console.WriteLine($"{_pizzaMgr.PrintMenu()}");
                    Console.WriteLine("Choose which pizza you'd like!");
                    int IDSearch1 = int.Parse(Console.ReadLine());
                    Pizza p1 = _pizzaMgr.SearchPizza(IDSearch1);
                    int orderID = IDSearch1;

                    Console.WriteLine("Customer name:");
                    string customerSearch = Console.ReadLine();
                    Customer c1 = _customerMgr.CustomerSearch(customerSearch);
                    string customerName1 = customerSearch;
                    if (p1 != null || c1 != null)
                    {
                        Console.WriteLine("Created a new order");
                        _orderMgr.CreateOrder(p1, c1);
                        

                    }
                    else
                    {
                        Console.WriteLine("Pizza doesn't exit");
                    }
                    

                    _menuCatalogMgr.PrintOptions();
                    int userchoice6 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice6);
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine($"You have chosen to add a customer:\nWrite customer name please");

                    string customerName = Console.ReadLine();
                    Console.WriteLine("Customer adress:");
                    string adress = Console.ReadLine();
                    Console.WriteLine($"Customer phone number:");
                    int phoneNumber = int.Parse(Console.ReadLine());

                    _customerMgr.CreateCustomer(new Customer(customerName, adress, phoneNumber));
                    Console.Write($"Your customers:\n");
                    Console.WriteLine($"{_customerMgr.PrintCustomer()}");
                    
                    _menuCatalogMgr.PrintOptions();
                    int userchoice8 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice8);
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine($"You have chosen to display the customers\n{_customerMgr.PrintCustomer()}");
                    _menuCatalogMgr.PrintOptions();
                    int userchoice9 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice9);
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine($"You have chosen to delete a customer\nType the name of who you want to remove, please\n{_customerMgr.PrintCustomer()}");
                    string deleteName = Console.ReadLine();
                    _customerMgr.RemoveCustomer(deleteName);
                    Console.WriteLine($"This is your updated customer list:\n{_customerMgr.PrintCustomer()}");

                    _menuCatalogMgr.PrintOptions();
                    int userchoice10 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice10);
                    break;

                case 10:
                    Console.Clear();
                   // Console.WriteLine($"You have chosen to display your order:\nOrder:\n{_orderMgr.PrintOrder()}"); *Doesn't work!*

                    _menuCatalogMgr.PrintOptions();
                    int userchoice11 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice11);
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    _menuCatalogMgr.PrintOptions();
                    int userchoice12 = int.Parse(Console.ReadLine());
                    UiMenu(userchoice12);
                    break;
            }

        }

    }
}



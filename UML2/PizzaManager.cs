using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class PizzaManager
    {
        List<Pizza> pizzas = new List<Pizza>();


        public void CreatePizza(Pizza pizza)
        {

            pizzas.Add(pizza);
        
        }

        public void RemovePizza(int ID)
        {
            pizzas.RemoveAll(Pizza => Pizza.ID == ID);

        }


        public Pizza SearchPizza(int ID)
        {
            for (int i = 0; i < pizzas.Count; i++)
            {
                bool pizzaExist = (pizzas[i].ID == ID);

                if (pizzaExist)
                {
                    Console.WriteLine($"{pizzas[i]}");
                    return pizzas[i];
                }

            }
            return null;
        }


        public string PrintMenu()
        {
            string menu = "";
            foreach (Pizza p in pizzas)
            {
                menu += ($"Pizza name: {p.Name}, Price: {p.Price}, ID: {p.ID}\n");
            }
            return menu;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML2
{


    public class Pizza
    {
        private string _name;
        private int _price;
        private int _ID;

       public Pizza(string name, int price, int ID)
        {
            _name = name;
            _price = price;
            _ID = ID;

            if (price < 50) 
            {
                throw new Exception("Pris skal være over 50 kr!");
            }

        } 

        public string Name
        {
            get { return _name; }
            private  set { _name = value; }
        }


        public int Price
        {
            get { return _price; }
            private set { _price = value; }
        }

        public int ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }


        public override string ToString() 
        {
            return $"Pizza name: {Name}, Price: {Price}, ID: {ID}";
        }
    }
}

    


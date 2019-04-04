//This is my own work
//Noah Vandervelden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagerTest
{
    class inventoryItem
    {
        public string id;
        public string size;
        public int stock;
        public string color;
        public string model;
        public string cost;

        //constructor
        public inventoryItem(string id, string size, int stock, string color, string model, string cost)
        {
            this.id = id;
            this.size = size;
            this.stock = stock;
            this.color = color;
            this.model = model;
            this.cost = cost;
        }

        override
        public string ToString()
        {
            string newString = "id: " + this.id + " size: " + this.size + " stock: " + this.stock + " color: " + this.color + " model: " + this.model + " cost: " + this.cost;
            return newString;
        }

        public string getID()
        {
            string newID = this.id;
            return newID;
        }

        public string getSize()
        {
            string newSize = this.size;
            return newSize;
        }
        public void setSize(String newSize)
        {
            this.size = newSize;
        }

        public int getStock()
        {
            int newInt = this.stock;
            return newInt;
        }
        public void setStock(int newInt)
        {
            this.stock = newInt;
        }

        public string getColor()
        {
            string newString = this.color;
            return newString;
        }
        public void setColor(String newString)
        {
            this.color = newString;
        }

        public string getModel()
        {
            string newString = this.model;
            return newString;
        }
        public void setModel(String newString)
        {
            this.model = newString;
        }

        public string getCost()
        {
            string newString = this.cost;
            return newString;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            inventoryManager iv = new inventoryManager();

            inventoryItem item1 = new inventoryItem("1237e", "7", 700, "Blue", "High Tops", "$70");
            inventoryItem item2 = new inventoryItem("1238e", "8", 90821, "Red", "Low Tops", "$70");
            inventoryItem item3 = new inventoryItem("1239e", "9", 7589732, "Orange", "Classics", "$70");


            bool addCheck = iv.Add(item1);
            if(addCheck == true)
                Console.WriteLine("added successfully");
            else
                Console.WriteLine("adding failed");

            addCheck = iv.Add(item2);
            if(addCheck == true)
                Console.WriteLine("added item 2 successfully");
            else
                Console.WriteLine("item 2 failed to add");

            addCheck = iv.Add(item3);
            if (addCheck == true)
                Console.WriteLine("added item 2 successfully");
            else
                Console.WriteLine("item 2 failed to add");



            foreach (inventoryItem item in iv.theList)
            {
                Console.WriteLine(item);
            }

            bool removeCheck = iv.removeItem(item1);
            if(removeCheck == true)
                Console.WriteLine("item 1 has been removed successfully");
            else
                Console.WriteLine("item 1 failed to be removed");

            foreach (inventoryItem item in iv.theList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("restocking item 2 to be 100000");

            iv.restock(item2, 100000);

            foreach (inventoryItem item in iv.theList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("enter a model to search");
            string search = Console.ReadLine();

            inventoryItem target = iv.findByModel(search);

            Console.WriteLine("search results: " + iv.findByModel(search).ToString());


            Console.WriteLine("Enter an id to search");
            search = Console.ReadLine();

            target = iv.findByID(search);

            Console.WriteLine(target);





        }
    }
}

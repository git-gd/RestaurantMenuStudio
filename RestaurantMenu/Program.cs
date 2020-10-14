using System;
using System.Reflection.Metadata.Ecma335;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            //The menu consists of several menu items.
            //The menu could be read from a text file...
            MenuItem menuItem = new MenuItem(true, 5.25, "main course", "Fishy fish fished from a fishery.");
            menu.AddItem(menuItem);

            menuItem = new MenuItem(false, 7.50, "main course", "Eggs. Just eggs.");
            menu.AddItem(menuItem);

            menuItem = new MenuItem(false, 3.33, "main course", "Burgar and fries.");
            menu.AddItem(menuItem);

            menuItem = new MenuItem(false, 8.66, "appetizer", "Salad");
            menu.AddItem(menuItem);

            menuItem = new MenuItem(false, 8.66, "appetizer", "Bread and butter.");
            menu.AddItem(menuItem);

            menuItem = new MenuItem(true, 1.50, "dessert", "Ice Cream");
            menu.AddItem(menuItem);

            menuItem = new MenuItem(false, 0.99, "dessert", "Cake");
            menu.AddItem(menuItem);


            string input = "";

            do
            {
                Console.WriteLine("Options:");
                Console.WriteLine("Press 1 to list the menu");
                Console.WriteLine("Press 2 to list a single item");
                Console.WriteLine("Press 3 to add an item to the menu");
                Console.WriteLine("Press X to exit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    menu.PrintMenu();
                }

                if (input == "2")
                {
                    Console.WriteLine("Enter the INDEX of an item to print"); //update to a better search! This is just for quick functionality
                    Console.WriteLine("Press X to exit");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int j))
                    {
                        menu.PrintItem(j);
                    }
                }

                if (input == "3")
                {
                    //ToDo .. take in put to add menu items
                    // input would be parsed or compared to fill out fields and then the object would be created once the information was validated

                    //bool isNew;

                    //int index;

                    //double cost;

                    //string description;

                    Console.WriteLine("Not yet implemented");
                }

            } while (input.ToUpper().Trim() != "X");

            menu.PrintMenu();

            menu.RemoveItem("Salad");

            menu.PrintMenu();

            if (menu.CompareItems(0, 1))
            {
                Console.WriteLine("They are the same!");
            } else
            {
                Console.WriteLine("They are different!");
            }

            if (menu.CompareItems(1, 1))
            {
                Console.WriteLine("They are the same!");
            }
            else
            {
                Console.WriteLine("They are different!");
            }

            menuItem = new MenuItem(false, 7.50, "main course", "Eggs. Just eggs.");
            menu.AddItem(menuItem);

            menu.PrintMenu();

        }
    }
}

//To review, here are the details you have from the restaurant owner:


//Each menu item has a price, description, and category (appetizer, main course, or dessert).
//It should be possible to display whether or not a menu item is new.
//The app should know when the menu was last updated, so visitors can see that the restaurant is constantly changing and adding exciting new items.
//Based on these details, you need to include some instance methods:

//A way to add and remove menu items from the menu.
//A way to tell if a menu item is new.
//A way to tell when the menu was last updated.
//A way to print out both a single menu item as well as the entire menu.
//A way to determine whether or not two menu items are equal.
//Starting with pen and paper (or your favorite notes application on your laptop), sketch out the methods that you need to add to these classes. List the method names and access levels, along with the types of all input and return parameters. Also, consider whether any methods should be static
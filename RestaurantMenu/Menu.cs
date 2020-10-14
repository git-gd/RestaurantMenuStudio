using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        List<MenuItem> MenuItems = new List<MenuItem>();
        DateTime lastUpdated = new DateTime();

        public void AddItem(MenuItem item)
        {
            if (!MenuItems.Contains(item))
            {
                MenuItems.Add(item);
                lastUpdated = DateTime.Now; // save the current time
            } else
            {
                Console.WriteLine("Duplicates not allowed!");
            }
        }

        public void RemoveItem(string itemDescription)
        {
            MenuItem found = new MenuItem(false, 0, "", ""); // must be a better way - to fix

            foreach (MenuItem item in MenuItems)
            {
                if (item.Description == itemDescription)
                {
                    found = item;
                }
            }

            MenuItems.Remove(found);
        }

        private void PrintLine(MenuItem output)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string isNew = (output.IsNew) ? "NEW!" : "Classic";
            Console.WriteLine($"{output.Id} {isNew} {output.Category} ${String.Format("{0:.00}", output.Price)} - {output.Description}");
            Console.ResetColor();
        }

        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Menu last update: {LastUpdated}");         

            for (int i = 0; i < MenuItems.Count; i++)
            {
                PrintLine(MenuItems[i]);
            }

        }

        public void PrintItem(int index)
        {
            if (index >= 0 && index < MenuItems.Count)
            {
                PrintLine(MenuItems[index]);
            }
        }

        //public MenuItem GetItem(int index)
        //{
        //    MenuItem item = MenuItems[index];
        //    return item;
        //}

        //public int Length()
        //{
        //    int menuItemsCount = MenuItems.Count;
        //    return menuItemsCount;
        //}

        public bool CompareItems(int first, int second)
        {
            return MenuItems[first].Equals(MenuItems[second]);
        }

        public DateTime LastUpdated => lastUpdated;
        
    }
}

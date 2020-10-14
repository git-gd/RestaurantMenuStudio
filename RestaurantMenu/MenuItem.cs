using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private static int nextId = 1; // static used to store the next available id

        // id of type int?
        public int Id { get; }
        public double Price { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }

        public bool IsNew { get; set; }

        public DateTime DateCreated {get;} // get but no set to make it read only.. or private and rely on IsNew method?

        public MenuItem(bool isNew, double price, string category, string description)
        {
            Id = nextId;
            nextId++;  // increment the static id field to the next available value
            Price = price;
            Category = category;
            Description = description;
            DateCreated = DateTime.Now;  // didn't end up using this field, considered using it for isNew but changed my mind and left the field
            IsNew = isNew;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Description == item.Description;
        }
    }
}

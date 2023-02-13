using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9Example
{
    internal class Inventory
    {
        public Inventory()
        {
            Id = 0;
            Name = "";
            Price = 0;
            Quantity = 0;
            Description = "";
        }

        // inven_id property
        public int Id { get; set; }

        // Name property
        public string Name { get; set; }

        // Cost property
        public int Price { get; set; }

        // Quantity property
        public int Quantity { get; set; }

        // Description property
        public string Description { get; set; }
    }
}

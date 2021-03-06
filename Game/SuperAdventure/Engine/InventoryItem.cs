﻿namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InventoryItem
    {
        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }

        public Item Details { get; set; }

        public int Quantity { get; set; }
    }
}

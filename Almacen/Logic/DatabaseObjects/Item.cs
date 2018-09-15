using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class Item
    {
        private int itemId;
        private string name;
        private string description;
        private decimal storePrice;
        private decimal customerPrice;
        private Category category;
        private Status status;

        public Item(int itemId, string name, string description, decimal storePrice, decimal customerPrice, Category category, Status status)
        {
            this.itemId = itemId;
            this.name = name;
            this.description = description;
            this.storePrice = storePrice;
            this.customerPrice = customerPrice;
            this.category = category;
            this.status = status;
        }

        public Item(string name, string description, decimal storePrice, decimal customerPrice, Category category, Status status)
        {
            this.itemId = 0;
            this.name = name;
            this.description = description;
            this.storePrice = storePrice;
            this.customerPrice = customerPrice;
            this.category = category;
            this.status = status;
        }


        public int ItemId { get => itemId; set => itemId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal StorePrice { get => storePrice; set => storePrice = value; }
        public decimal CustomerPrice { get => customerPrice; set => customerPrice = value; }
        public Category Category { get => category; set => category = value; }
        public Status Status { get => status; set => status = value; }

        public override string ToString()
        {
            return itemId + " " + name;
        }
    }
}

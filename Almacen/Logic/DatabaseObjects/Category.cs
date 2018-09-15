using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class Category
    {
        private int categoryId;
        private string name;

        public Category(int categoryId, string name)
        {
            this.CategoryId = categoryId;
            this.Name = name;
        }

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}

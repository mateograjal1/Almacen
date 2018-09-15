using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class Status
    {
        private int statusId;
        private string name;

        public Status(int categoryId, string name)
        {
            this.statusId = categoryId;
            this.name = name;
        }

        public int StatusId { get => statusId; set => statusId = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}

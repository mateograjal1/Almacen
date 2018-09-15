using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class Role
    {
        private string role;
        private int id;

        public Role(string role, int id)
        {
            this.role = role;
            this.id = id;
        }

        public string RoleName { get => role; }
        public int Id { get => id; }

        public override string ToString()
        {
            return RoleName;
        }
    }
}

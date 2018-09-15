using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class Person
    {
        private int id;
        private string name;
        private string lastName;
        private string dob;
        private string address;
        private string email;
        private string phone;
        private int roleId;

        public Person(int id, string name, string lastName, string dob, string address, string email, string phone, int roleId)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.dob = dob;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.roleId = roleId;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public int RoleId { get => roleId; set => roleId = value; }
    }
}

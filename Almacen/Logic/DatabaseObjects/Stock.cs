using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class Stock
    {
        private int id;
        private float amount;
        private DateTime date;

        public Stock(int id, float amount)
        {
            this.Id = id;
            this.Amount = amount;
            this.Date = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public float Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}

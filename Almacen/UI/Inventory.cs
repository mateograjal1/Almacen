using Almacen.Logic;
using Almacen.Logic.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen.UI
{
    public partial class Inventory : Form
    {
        private bool valid = false;

        public bool Valid { get => valid; }
        public DataTable NewInventory { get => (DataTable)dgvInventory.DataSource; }

        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valid = true;
            List<Stock> list = ObjectFactory.createStockList((DataTable)dgvInventory.DataSource);
            DBConnection.UpdateStock(list);
            Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dgvInventory.DataSource = DBConnection.GetItemStock();
            dgvInventory.Columns[0].ReadOnly = true;
            dgvInventory.Columns[1].ReadOnly = true;
            dgvInventory.Columns[2].ReadOnly = true;
            dgvInventory.Columns[3].ReadOnly = false;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            valid = false;
            Close();
        }
    }
}

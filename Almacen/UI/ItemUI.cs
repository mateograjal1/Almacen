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
    public partial class ItemUI : Form
    {
        private bool valid = false;
        private bool another = true;

        public bool Valid { get => valid; }
        public bool Another { get => another; }

        public ItemUI()
        {
            InitializeComponent();
        }

        public ItemUI(string name, string description, decimal storePrice, decimal customerPrice, int category, int status)
        {
            InitializeComponent();
            this.txtName.Text = name;
            this.txtDescription.Text = description;
            this.txtStorePrice.Text = storePrice.ToString();
            this.txtCustomerPrice.Text = customerPrice.ToString();
            foreach (Category cat in cbxCategory.Items)
            {
                if (cat.CategoryId == category)
                {
                    cbxCategory.SelectedItem = cat;
                }
            }
            foreach (Status stat in cbxStatus.Items)
            {
                if (stat.StatusId == status)
                {
                    cbxStatus.SelectedItem = stat;
                }
            }
            butOKNew.Enabled = false;
            butOKNew.Hide();
        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            DataTable dtStatuses = DBConnection.GetStatuses();
            DataTable dtCategories = DBConnection.GetCategories();
            List<Status> statuses = ObjectFactory.createStatusList(dtStatuses);
            List<Category> categories = ObjectFactory.createCategoryList(dtCategories);
            cbxStatus.DataSource = statuses;
            cbxCategory.DataSource = categories;
        }

        public Item GetItem()
        {            
            string name = txtName.Text, description = txtDescription.Text;
            decimal storePrice = Decimal.Parse(txtStorePrice.Text), customerPrice = Decimal.Parse(txtCustomerPrice.Text);
            Category category = (Category)cbxCategory.SelectedItem;
            Status status = (Status)cbxStatus.SelectedItem;
            return new Item(name, description, storePrice, customerPrice, category, status);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            valid = true;
            another = false;
            Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            valid = false;
            another = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valid = true;
            another = true;
            Close();
        }
    }
}

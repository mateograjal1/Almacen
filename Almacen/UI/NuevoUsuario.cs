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
    public partial class NuevoUsuario : Form
    {
        private string[] users;
        private bool valid = false;
        private Person person;
        private string user;
        private string password;

        public bool Valid { get => valid; }
        public Person Person { get => person; }
        public string User { get => user; }
        public string Password { get => password; }

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            DataTable dtRoles = DBConnection.GetRoles();
            cbxRol.DataSource = ObjectFactory.createRoleList(dtRoles);
            DataTable dtUsuarios = DBConnection.GetUsers();
            users = new string[dtUsuarios.Rows.Count];
            int index = 0;
            foreach (DataRow row in dtUsuarios.Rows)
            {
                users[index++] = (string)row[0];
            }
            dtpDOB.Text = "";
        }

        private bool checkUser()
        {
            string[] query = (from String s in users where s == txtUser.Text select s).ToArray();
            if (query.Length == 0)
            {
                return true;
            }
            return false;
        }

        private bool checkPassword()
        {
            return txtPassword1.Text == txtPassword2.Text;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtUser.Text == "" || txtPassword1.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Debe completar todo el formulario");
            }
            else
            {
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string date = dtpDOB.Value.ToString("yyyy-MM-dd");
                string phone = txtPhoneNumber.Text;
                int role = ((Role)cbxRol.SelectedItem).Id;
                if (checkUser())
                {
                    string user = txtUser.Text;
                    if (checkPassword())
                    {
                        password = Crypto.Encrypt(txtPassword1.Text);
                        this.user = txtUser.Text;
                        person = new Person(0, name, lastName, date, address, email, phone, role);
                        valid = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no disponible");
                }
            }
            
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            valid = false;
            Close();
        }
    }
}

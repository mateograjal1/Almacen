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
    public partial class LogIn : Form
    {
        private bool valid = false;
        private string user;
        private string password;

        public LogIn()
        {
            InitializeComponent();
        }

        public bool Valid { get => valid; }
        public string User { get => user; }
        public string Password { get => password; }

        private void button1_Click(object sender, EventArgs e)
        {
            valid = true;
            user = txtUser.Text;
            password = txtPassword.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valid = false;
            Close();
        }
    }
}

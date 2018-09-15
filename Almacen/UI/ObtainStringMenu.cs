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
    public partial class ObtainStringMenu : Form
    {
        private string title;
        private string sentence;
        private bool valid = false;

        public string UserString { get => txtUserString.Text; }
        public bool Valid { get => valid; }

        public ObtainStringMenu(string title, string sentence)
        {
            InitializeComponent();
            this.title = title;
            this.sentence = sentence;
        }

        private void ObtainStringMenu_Load(object sender, EventArgs e)
        {
            Text = title;
            lblText.Text = sentence;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            valid = true;
            Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            valid = false;
            Close();
        }
    }
}

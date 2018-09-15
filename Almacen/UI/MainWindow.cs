using Almacen.Logic;
using Almacen.Logic.DatabaseObjects;
using Almacen.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen
{
    public partial class MainWindow : Form
    {
        private Role currentRole = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void updateRole()
        {
            switch (currentRole.Id)
            {
                case 10000: //SuperAdmin
                    inventarioToolStripMenuItem.Enabled = true;
                    adicionalToolStripMenuItem.Enabled = true;
                    personasToolStripMenuItem.Enabled = true;
                    mantenimientoToolStripMenuItem.Enabled = true;
                    nuevoArticuloToolStripMenuItem.Enabled = true;
                    nuevaCategoriaToolStripMenuItem.Enabled = true;
                    nuevoEstadoToolStripMenuItem.Enabled = true;
                    editarArticuloToolStripMenuItem.Enabled = true;
                    break;
                case 10001: //Admin
                    inventarioToolStripMenuItem.Enabled = true;
                    adicionalToolStripMenuItem.Enabled = true;
                    personasToolStripMenuItem.Enabled = true;
                    mantenimientoToolStripMenuItem.Enabled = false;
                    nuevoArticuloToolStripMenuItem.Enabled = true;
                    nuevaCategoriaToolStripMenuItem.Enabled = true;
                    nuevoEstadoToolStripMenuItem.Enabled = true;
                    editarArticuloToolStripMenuItem.Enabled = true;
                    break;
                case 10002: //Manager
                    inventarioToolStripMenuItem.Enabled = true;
                    adicionalToolStripMenuItem.Enabled = true;
                    personasToolStripMenuItem.Enabled = false;
                    nuevoArticuloToolStripMenuItem.Enabled = false;
                    nuevaCategoriaToolStripMenuItem.Enabled = false;
                    nuevoEstadoToolStripMenuItem.Enabled = false;
                    editarArticuloToolStripMenuItem.Enabled = false;
                    mantenimientoToolStripMenuItem.Enabled = false;
                    break;
                case 10003: //Employee
                    inventarioToolStripMenuItem.Enabled = true;
                    adicionalToolStripMenuItem.Enabled = false;
                    personasToolStripMenuItem.Enabled = false;
                    nuevoArticuloToolStripMenuItem.Enabled = false;
                    nuevaCategoriaToolStripMenuItem.Enabled = false;
                    nuevoEstadoToolStripMenuItem.Enabled = false;
                    editarArticuloToolStripMenuItem.Enabled = false;
                    mantenimientoToolStripMenuItem.Enabled = false;
                    break;
                case 10004: //No role
                    inventarioToolStripMenuItem.Enabled = false;
                    adicionalToolStripMenuItem.Enabled = false;
                    personasToolStripMenuItem.Enabled = false;
                    nuevoArticuloToolStripMenuItem.Enabled = false;
                    nuevaCategoriaToolStripMenuItem.Enabled = false;
                    nuevoEstadoToolStripMenuItem.Enabled = false;
                    editarArticuloToolStripMenuItem.Enabled = false;
                    mantenimientoToolStripMenuItem.Enabled = false;
                    break;
                default:
                    inventarioToolStripMenuItem.Enabled = false;
                    adicionalToolStripMenuItem.Enabled = false;
                    personasToolStripMenuItem.Enabled = false;
                    nuevoArticuloToolStripMenuItem.Enabled = false;
                    nuevaCategoriaToolStripMenuItem.Enabled = false;
                    nuevoEstadoToolStripMenuItem.Enabled = false;
                    editarArticuloToolStripMenuItem.Enabled = false;
                    mantenimientoToolStripMenuItem.Enabled = false;
                    break;
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Hide();            
            inventarioToolStripMenuItem.Enabled = false;
            adicionalToolStripMenuItem.Enabled = false;
            personasToolStripMenuItem.Enabled = false;
            mantenimientoToolStripMenuItem.Enabled = false;
            iniciarSesionToolStripMenuItem.PerformClick();
        }

        private void mostrarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = DBConnection.GetItemStock();
        }

        private void ingresaArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool another = true;
            while (another)
            {
                ItemUI na = new ItemUI();
                na.ShowDialog();
                if (na.Valid)
                {
                    DBConnection.AddItem(na.GetItem());                    
                    dgvResultados.DataSource = DBConnection.getItems();
                }
                another = na.Another;
            }
        }

        private void mostrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            dgvResultados.DataSource = DBConnection.GetCategories();
        }

        private void mostrarEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            dgvResultados.DataSource = DBConnection.GetStatuses();
        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtainStringMenu osm = new ObtainStringMenu("Nueva Categoria", "Ingrese el nombre para la nueva categoria");
            osm.ShowDialog();
            if (osm.Valid)
            {
                DBConnection.AddCategory(osm.UserString);
            }
        }

        private void nuevoEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtainStringMenu osm = new ObtainStringMenu("Nuevo estado", "Ingrese el nombre para el nuevo estado");
            osm.ShowDialog();
            if (osm.Valid)
            {
                DBConnection.AddStatus(osm.UserString);
            }
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tries = 3;
            do
            {
                LogIn li = new LogIn();
                li.ShowDialog();
                if (li.Valid)
                {
                    string user = li.User;
                    string password = Crypto.Encrypt(li.Password);
                    DataTable dt = DBConnection.CheckLogIn(user, password);
                    if (dt.Rows.Count == 1)
                    {
                        switch ((int)dt.Rows[0][0])
                        {
                            case 10000:
                                currentRole = new Role("SuperAdmin", 10000);
                                break;
                            case 10001:
                                currentRole = new Role("Admin", 10001);
                                break;
                            case 10002:
                                currentRole = new Role("Manager", 10002);
                                break;
                            case 10003:
                                currentRole = new Role("Employee", 10003);
                                break;
                            case 10004:
                                currentRole = new Role("No role", 10004);
                                break;
                            default:
                                currentRole = null;
                                break;
                        }
                        updateRole();
                        tsslUser.Text = (string)dt.Rows[0][2];
                        tsslRole.Text = currentRole.ToString();
                        if (!this.Visible)
                        {
                            Show();
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show(null, "Usuario o contraseña incorrectos\nIntentos restantes: " + --tries, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } while (tries > 0);
            if (tries == 0)
            {
                MessageBox.Show("Usuario incorrecto muchas veces\nCerrando programa");
                Close();
            }
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario nu = new NuevoUsuario();
            nu.ShowDialog();
            if (nu.Valid)
            {
                DBConnection.AddPerson(nu.Person, nu.User, nu.Password);
            }
        }

        private void mostrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = DBConnection.getStaff();
        }

        private void proximamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola!\nGracias por descargar la version gratuita de Inventario Plus 9000 XL Ultra revolution remastered Edition\nContacte con el encargado de la compra de Software en su empresa para comprar la version completa");
        }

        private void mostrarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = DBConnection.getItems();
        }

        private void editarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtainStringMenu osm = new ObtainStringMenu("Borrar articulo", "Ingrese codigo del articulo");
            osm.ShowDialog();
            if (osm.Valid)
            {
                int id;
                if (Int32.TryParse(osm.UserString, out id))
                {
                    DBConnection.DeleteItem(id);
                    dgvResultados.DataSource = DBConnection.getItems();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un codigo valido");
                }
            }
        }

        private void hacerInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.ShowDialog();
            if (i.Valid)
            {
                dgvResultados.DataSource = DBConnection.GetItemStock();
            }
        }
    }
}

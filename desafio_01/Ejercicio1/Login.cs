using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Login : Form
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
    {
        { "Camila", "CJ220498" },    // Usuario 1
        { "Caleb", "PD230166" }    // Usuario 2
    };
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (users.ContainsKey(usuario) && users[usuario] == contraseña)
            {
                this.Hide();
                Principal mainForm = new Principal();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
    }
}

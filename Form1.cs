using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Alvaro
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private int intentos = 0;

        private Dictionary<string, string> usuariosYContrasenas = new Dictionary<string, string>
{
    { "Alvaro", "1234" },
    { "Gabriel", "cbtis" },
};

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxusua.Text;
            string contrasena = textBoxcontra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("La longitud del usuario debe ser al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuariosYContrasenas.ContainsKey(usuario) && usuariosYContrasenas[usuario] != contrasena)
            {
                MessageBox.Show("Usuario correcto, contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (!usuariosYContrasenas.ContainsKey(usuario))
            {
                MessageBox.Show("Usuario incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (usuariosYContrasenas.ContainsKey(usuario) && usuariosYContrasenas[usuario] == contrasena)
            {
                MessageBox.Show("¡Bienvenido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear una instancia del formulario que deseas abrir (reemplaza 'Formmenu' con el nombre real de tu formulario)
                Formmenu home = new Formmenu();

                // Mostrar el formulario
                home.Show();

                // Ocultar la ventana de inicio de sesión
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }












        private void button3_Click_1(object sender, EventArgs e)
        {
            Formhome home = new Formhome();
            home.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
    


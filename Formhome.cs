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
    public partial class Formhome : Form
    {
        public Formhome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                    // Guardar los datos ingresados en variables.
                    string campo1 = textBox1.Text;
                    string campo2 = textBox2.Text;
                    string campo3 = textBox3.Text;
                    string campo4 = textBox4.Text;
                  

                    // Luego, puedes hacer lo que necesites con estos datos, como mostrarlos en un MessageBox.
                    string mensaje = $"Datos guardados:\nCampo 1: {campo1}\nCampo 2: {campo2}\nCampo 3: {campo3}\nCampo 4: {campo4}\nCampo 5: {campo1}";
                    MessageBox.Show(mensaje, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // También puedes guardarlos en una estructura de datos, una base de datos o realizar cualquier otra acción necesaria con los datos.
                Form1 Form = new Form1();
                Form.Show();

                // También puedes cerrar la ventana actual si ya no es necesaria.
                this.Hide();
            }
        }
    }
}

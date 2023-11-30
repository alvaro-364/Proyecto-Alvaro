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
    public partial class venta_producto : Form
    {
        public venta_producto()
        {
            InitializeComponent();
        }

        private void dataestudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataestudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("debes seleccionar un renglon", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                textBox1.Text = dataestudiante.CurrentRow.Cells["producto"].Value.ToString();
                textBox2.Text = dataestudiante.CurrentRow.Cells["precio"].Value.ToString();
                textBox3.Text = dataestudiante.CurrentRow.Cells["numero de productos"].Value.ToString();
                comboBox1.Text = dataestudiante.CurrentRow.Cells["Nombre del local"].Value.ToString();
                textBox4.Text = dataestudiante.CurrentRow.Cells["Ganancias"].Value.ToString();
                textBox5.Text = dataestudiante.CurrentRow.Cells["Numero del local"].Value.ToString();



            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataestudiante.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataestudiante.SelectedRows[0];

                // Actualiza los valores de la fila seleccionada con los valores de los controles
                selectedRow.Cells["producto"].Value = textBox1.Text;
                selectedRow.Cells["precio"].Value = textBox2.Text;
                selectedRow.Cells["numerodeproductos"].Value = textBox3.Text;
                selectedRow.Cells["Nombredellocal"].Value = comboBox1.Text;
                selectedRow.Cells["numerodelocal"].Value = textBox4.Text;
                selectedRow.Cells["provedor"].Value = textBox6.Text;
                selectedRow.Cells["lugar_procedencia"].Value = textBox7.Text;
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón para actualizar", "Actualizando estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "Desea eliminar el registro?";
            string titulo = "Eliminando el registro";
            if (!(dataestudiante.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataestudiante.Rows.Remove(dataestudiante.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "eliminando estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar un renglon", "!Eliminado estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(dataestudiante);

                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox2.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = textBox4.Text;
                renglon.Cells[5].Value = textBox5.Text;


                dataestudiante.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AGREGANDO ESTUDIANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Microsoft_Yahei_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
            {
            Formdata2 home = new Formdata2();
            home.Show();
            this.Hide();
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Local_Click(object sender, EventArgs e)
        {

        }
    }
    }




















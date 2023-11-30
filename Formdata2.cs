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
    public partial class Formdata2 : Form
    {
        public Formdata2()
        {
            InitializeComponent();
        }

        private void Formdata2_Load(object sender, EventArgs e)
        {
            



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(dataproducto);

                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox2.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = textBox4.Text;
                renglon.Cells[4].Value = textBox5.Text;
                renglon.Cells[5].Value = textBox6.Text;
                renglon.Cells[6].Value = textBox7.Text;
                renglon.Cells[7].Value = textBox8.Text;

                dataproducto.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AGREGANDO ESTUDIANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "Desea eliminar el registro?";
            string titulo = "Eliminando el registro";
            if (!(dataproducto.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataproducto.Rows.Remove(dataproducto.CurrentRow);
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

        private void dataproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataproducto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("debes seleccionar un renglon", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                textBox1.Text = dataproducto.CurrentRow.Cells["id_de_producto"].Value.ToString();
                textBox2.Text = dataproducto.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox3.Text = dataproducto.CurrentRow.Cells["Descuento"].Value.ToString();
                textBox4.Text = dataproducto.CurrentRow.Cells["Herramienta"].Value.ToString();
                textBox5.Text = dataproducto.CurrentRow.Cells["Cantidad_prdfucto"].Value.ToString();
                textBox6.Text = dataproducto.CurrentRow.Cells["Precio"].Value.ToString();
                textBox7.Text = dataproducto.CurrentRow.Cells["provedor"].Value.ToString();
                textBox8.Text = dataproducto.CurrentRow.Cells["Lugar_procedencia"].Value.ToString();



            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonUptade_Click(object sender, EventArgs e)
        {
            {
                if (dataproducto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataproducto.SelectedRows[0];

                    // Actualiza los valores de la fila seleccionada con los valores de los controles
                    selectedRow.Cells["id_de_producto"].Value = textBox1.Text;
                    selectedRow.Cells["Nombre"].Value = textBox2.Text;
                    selectedRow.Cells["Descuento"].Value = textBox3.Text;
                    selectedRow.Cells["Herramienta"].Value = textBox4.Text;
                    selectedRow.Cells["Cantidad_prdfucto"].Value = textBox2.Text;
                    selectedRow.Cells["Precio"].Value = textBox5.Text;
                    selectedRow.Cells["provedor"].Value = textBox6.Text;
                    selectedRow.Cells["Lugar_procedencia"].Value = textBox7.Text;
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un renglón para actualizar", "Actualizando estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    }
    
    


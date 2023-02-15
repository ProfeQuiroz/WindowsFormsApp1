using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }
        int velocidad, tiempo, distancia;
        double conversion;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void borrarlistabutton_Click(object sender, EventArgs e)
        {
            distanciadataGridView.Rows.Clear();
            limpiarcampos();
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.Cancel;
            limpiarcampos();
            errorProvider.Clear();
        }

        private void limpiarcampos()
        {
            velocidadtextBox.Clear();
            tiempotextBox.Clear();
            velocidadtextBox.Focus();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmarbutton_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                velocidad = int.Parse(velocidadtextBox.Text);
                tiempo = int.Parse(tiempotextBox.Text);
                distancia = obtenerdistancia(velocidad, tiempo);
                conversion = obtenerconversion(distancia);
                var r = construirfila();
                setearfila(r, velocidad, tiempo, distancia, conversion);
                agregarfila(r);
                limpiarcampos();

            }
        }

        private void agregarfila(DataGridViewRow r)
        {
            distanciadataGridView.Rows.Add(r);
        }

        private void setearfila(DataGridViewRow r, int velocidad, int tiempo, int distancia, double conversion)
        {
            r.Cells[colvelocidad.Index].Value=velocidad.ToString();
            r.Cells[coltiempo.Index].Value = tiempo.ToString();
            r.Cells[Coldistancia.Index].Value = distancia.ToString();
            r.Cells[colconversion.Index].Value = conversion.ToString();
        }

        private DataGridViewRow construirfila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(distanciadataGridView);
            return r;
        }

        private double obtenerconversion(int distancia) => distancia * 0.001;
       

        private int obtenerdistancia(int velocidad, int tiempo) => velocidad * tiempo;

        private void velocidadtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validardatos()
        {
            errorProvider.Clear();
            bool valido = true;
            if (!int.TryParse(velocidadtextBox.Text, out velocidad))
            {
                valido = false;
                errorProvider.SetError(velocidadtextBox, "El dato a ingresar debe ser un número ");
            }
            else
            {
                if (velocidad <= 0)
                {
                    valido = false;
                    errorProvider.SetError(velocidadtextBox, "El dato a ingresar debe ser positivo ");

                }
                else
                {
                    if (velocidad >= 101)
                    {
                        valido = false;
                        errorProvider.SetError(velocidadtextBox, "El dato a ingresar debe ser menor a 100 ");
                    }
                }
            }
            if (!int.TryParse(tiempotextBox.Text, out tiempo))
            {
                valido = false;
                errorProvider.SetError(tiempotextBox, "El dato a ingresar debe ser un número ");
            }
            else
            {
                if (tiempo <= 0)
                {
                    valido = false;
                    errorProvider.SetError(tiempotextBox, "El dato a ingresar debe ser positivo ");
                }
            }
            return valido;
        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea usted salir del formulario?",
                       "confirmar selección",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        

    }
    

}

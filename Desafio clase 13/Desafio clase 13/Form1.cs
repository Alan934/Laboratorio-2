using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_clase_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void bottonCalcular(object sender, EventArgs e)
        {
            try 
            {
                int numeroPiso, numeroVentanas, añosAntiguedad;
                double precio, superficie;
                numeroPiso = Int32.Parse(txtPiso.Text);
                numeroVentanas = Int32.Parse(txtLocal.Text);
                precio = Convert.ToDouble(txtPrecio.Text);
                superficie = Convert.ToDouble(txtSuperficie.Text);
                añosAntiguedad = Int32.Parse(txtAntiguedad.Text);

                Local local = new Local(numeroVentanas, precio, superficie, añosAntiguedad);
                Piso piso = new Piso(numeroPiso, precio, superficie, añosAntiguedad);

                if (radioButtonLocal.Checked == true)
                {
                    double mostrarPrecio = local.CalculosFinalLocal();
                    labelPrecioFinal.Text = mostrarPrecio.ToString();
                    labelMostrarAños.Text = "Descuento por años de antiguedad: $" + local.CalculoAños().ToString();
                    mostrarVentanas(numeroVentanas, local.MostrarVentanas());
                    labelMostrarsuperficie.Text = "Aumento por superficie: $" + local.CalculoSuperficie();
                }
                if (radioButtonPiso.Checked == true)
                {
                    double mostrarPrecio = piso.CalculoFinalPiso();
                    labelPrecioFinal.Text = mostrarPrecio.ToString();
                    labelMostrarAños.Text = "Descuento por años de antiguedad: $" + piso.CalculoAños().ToString();
                    labelMostrarNumeroPiso.Text = "Aumento por numero de Piso: $" + piso.CalculoPiso().ToString();
                }
                if (numeroPiso < 0 || numeroVentanas < 0 || precio < 0 || añosAntiguedad < 0 || superficie < 0)
                {
                    MessageBox.Show("No se pueden ingresar numeros negativos.", "Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
        }

        private void radioButtonPiso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPiso.Checked == true)
            {
                txtLocal.Enabled = false;
            }
            else
            {
                txtLocal.Enabled = true;
            }
        }

        private void radioButtonLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLocal.Checked == true)
            {
                txtPiso.Enabled = false;
            }
            else
            {
                txtPiso.Enabled = true;
            }
        }

        private void mostrarVentanas( int numeroVentanas, double i)
        {
            if (numeroVentanas <= 4 && numeroVentanas >= 2)
            {
                labelMostrarVentanas.Text = "Por tener entre 4 y 2 ventanas: $" + i;
            }
            if (numeroVentanas > 4)
            {
                labelMostrarVentanas.Text = "Por tener mas de 4 ventanas, aumento de 2%: $" + i;
            }
            else if (numeroVentanas <= 1)
            {
                labelMostrarVentanas.Text = "Por tener 1 o menos ventanas descuento del 2%: $" + i;
            }
        }
    }
}

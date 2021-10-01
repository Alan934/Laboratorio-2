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
            Calcular calculos;

            /*String numeroPiso = txtPiso.Text;
            String numeroVentanas = txtLocal.Text;
            String precio = txtPrecio.Text;
            String superficie = txtSuperficie.Text;
            String añosAntiguedad = txtAntiguedad.Text;*/

            int numeroPisoi = Int32.Parse(txtPiso.Text);
            int numeroVentanasi = Int32.Parse(txtLocal.Text);
            double preciod = double.Parse(txtPrecio.Text);
            double superficied = double.Parse(txtSuperficie.Text);
            int añosAntiguedadi = Int32.Parse(txtAntiguedad.Text); 

             calculos = new Calcular(numeroPisoi, numeroVentanasi, preciod, superficied, añosAntiguedadi);
            //Calcular calculos = new Calcular();
            //calculos.NumeroPiso = txtPiso.Text;

            if (radioButtonLocal.Checked == true)
            {
                double mostrarPrecio = double.Parse(labelPrecioFinal.Text);
                mostrarPrecio = calculos.CalculosFinalLocal();
                //labelPrecioFinal.Text = calculos.CalculosFinalLocal();
                //MessageBox.Show("Precio a pagar: $");
            }
            if (radioButtonPiso.Checked == true)
            {
                double mostrarPrecio2 = double.Parse(labelPrecioFinal.Text);
                mostrarPrecio2 = calculos.CalculosPiso();
            }
        }
    }
}

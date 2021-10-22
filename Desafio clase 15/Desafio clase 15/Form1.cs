using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_clase_15
{
    public partial class Form1 : Form
    {
        double precioTotal = 0;
        double totalTele = 0;
        double totalLavadora = 0;
        double totalElectrodomestico = 0;


        public Form1()
        {
            InitializeComponent();
        }

        ArrayList electrodomesticos = new ArrayList();
        
        private void radioButtonElectrodomestico_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonElectrodomestico.Checked == true)
            {
                txtCarga.Enabled = false;
                txtResolucion.Enabled = false;
                radioButtonSintonizador.Enabled = false;
                radioButtonSintonizadorNo.Enabled = false;
            }
            else
            {
                txtCarga.Enabled = true;
                txtResolucion.Enabled = true;
                radioButtonSintonizador.Enabled = true;
                radioButtonSintonizadorNo.Enabled = true;
            }
        }

        private void radioButtonLavadora_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonLavadora.Checked == true)
            {
                txtResolucion.Enabled = false;
                radioButtonSintonizador.Enabled = false;
                radioButtonSintonizadorNo.Enabled = false;
            }
            else
            {
                txtResolucion.Enabled = true;
                radioButtonSintonizador.Enabled = true;
                radioButtonSintonizadorNo.Enabled = true;
            }
        }

        private void radioButtonTelevision_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTelevision.Checked == true)
            {
                txtCarga.Enabled = false;
            }
            else
            {
                txtCarga.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonElectrodomestico.Checked == true)
                {
                    Electrodomestico electro = new Electrodomestico(Convert.ToDouble(txtPrecioBase.Text), Convert.ToDouble(txtPeso.Text));
                    electro.ComprobarConsumoEnergetico(electro.Letra = txtConsumo.Text);
                    electro.ComprobarColor(txtColor.Text);
                    labelPrecioElectrodomesticos.Text = electro.PrecioFinal().ToString();
                    electrodomesticos.Add(electro);
                    labelProductoCarrito.Text = "Electrodomestico Añadido";

                    if (txtPrecioBase.Text == null && txtPeso.Text == null)
                    {
                        Electrodomestico electroDefecto = new Electrodomestico();
                        electroDefecto.PrecioFinal();
                        labelPrecioElectrodomesticos.Text = electroDefecto.PrecioFinal().ToString();
                        electrodomesticos.Add(electroDefecto);
                        labelProductoCarrito.Text = "Electrodomestico Añadido por defecto";
                    }

                    //totalElectrodomestico = electro.PrecioFinal();
                }

                if (radioButtonLavadora.Checked == true)
                {
                    Lavadora lavadora = new Lavadora(Int32.Parse(txtCarga.Text));
                    lavadora.PrecioBase = Convert.ToDouble(txtPrecioBase.Text);
                    lavadora.Peso = Convert.ToDouble(txtPeso.Text);
                    lavadora.Color = txtColor.Text;
                    lavadora.ComprobarColor(txtColor.Text);
                    lavadora.ComprobarConsumoEnergetico(lavadora.Letra = txtConsumo.Text);
                    lavadora.PrecioFinal();
                    labelPrecioLavadoras.Text = lavadora.PrecioFinalLavadora().ToString();
                    electrodomesticos.Add(lavadora);
                    labelProductoCarrito.Text = "Lavadora Añadida";

                    //totalLavadora = lavadora.PrecioFinalLavadora();
                }

                if (radioButtonTelevision.Checked == true)
                {
                    Television tele = new Television(Int32.Parse(txtResolucion.Text), radioButtonSintonizador.Checked);
                    tele.PrecioBase = Convert.ToDouble(txtPrecioBase.Text);
                    tele.Peso = Convert.ToDouble(txtPeso.Text);
                    tele.Color = txtColor.Text;
                    tele.ComprobarColor(txtColor.Text);
                    tele.ComprobarConsumoEnergetico(tele.Letra = txtConsumo.Text);
                    tele.PrecioFinal();
                    labelPrecioTelevisores.Text = tele.PrecioFinalTele().ToString();
                    electrodomesticos.Add(tele);
                    labelProductoCarrito.Text = "Televisor Añadido";

                    if (txtResolucion.Text == "" && radioButtonSintonizador.Checked == false)
                    {
                        Television teleDefecto = new Television();
                        teleDefecto.PrecioBase = Convert.ToDouble(txtPrecioBase.Text);
                        teleDefecto.Peso = Convert.ToDouble(txtPeso.Text);
                        teleDefecto.Color = txtColor.Text;
                        teleDefecto.ComprobarColor(txtColor.Text);
                        teleDefecto.ComprobarConsumoEnergetico(teleDefecto.Letra = txtConsumo.Text);
                        teleDefecto.PrecioFinal();
                        labelPrecioTelevisores.Text = teleDefecto.PrecioFinalTele().ToString();
                        electrodomesticos.Add(teleDefecto);
                        labelProductoCarrito.Text = "Televisor Añadido por Defecto";
                    }

                    //totalTele = tele.PrecioFinalTele();
                }

                //precioTotal = totalLavadora + totalTele + totalElectrodomestico;

                foreach (double i in electrodomesticos)
                {
                    precioTotal = precioTotal + i;
                }

                labelPrecioTotal.Text = precioTotal.ToString();
                labelMostrarCantidad.Text = electrodomesticos.Count.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                electrodomesticos.RemoveAt(Int32.Parse(txtRemove.Text));
                labelMostrarRemove.Text = "Objeto eliminado del carrito con exito.";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            electrodomesticos.Clear();
            labelMostrarRemove.Text = "Todos los objetos eliminados del carrito con exito.";
        }
    }
}

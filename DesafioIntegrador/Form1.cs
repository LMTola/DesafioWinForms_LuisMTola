using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbCamisa.Checked = true;
            rbtStandard.Checked = true;

        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            chkMangaCorta.Enabled = true;
            chkBermuda.Enabled = false;

        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            chkMangaCorta.Enabled = false;
            chkBermuda.Enabled = true;
            chkMangaCorta.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)

        {
            try
            {


                if (rbCamisa.Checked == true)
                {
                    Camisa camisa = new Camisa(chkMangaCorta.Checked, rbtStandard.Checked, rbtPremium.Checked, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
                    camisa.CalcularPrecio();
                    MessageBox.Show("El precio Total es: " + camisa.Precio);
                }
                else if (rbPantalon.Checked == true)
                {
                    Pantalon pantalon = new Pantalon(chkBermuda.Checked, rbtStandard.Checked, rbtPremium.Checked, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
                    pantalon.CalcularPrecio();
                    MessageBox.Show("El precio Total es: " + pantalon.Precio);
                }
                else
                {
                    MessageBox.Show("Error, Seleccione alguna prenda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor en Precio y Cantidad");
            }
        }

        private void labelTituloForms_Click(object sender, EventArgs e)
        {

        }

        private void chkBermuda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

            if (!(txtPrecio.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            if (!(txtPrecio.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");
        }

        private void rbtStandard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public static class StringHelper
    {
        public static bool EsNumero(this string str)
        {
            double _val;
            bool valor = double.TryParse(str, out _val);
            return valor;
        }

    }


}
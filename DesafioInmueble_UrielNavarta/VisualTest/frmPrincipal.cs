using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTest
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CalculadorSupremo_Click(object sender, EventArgs e)
        {

            if (btnPiso.Checked)
            {
                String direccion = tbDireccion.Text;
                int antiguedad = Convert.ToInt32(tbEdad.Text);
                int precioBase = Convert.ToInt32(tbPrecio.Text);
                int nroPiso = Convert.ToInt32(tbPiso.Text);

                if (validarSopi() && validarEdad() && validarPrecio())
                {
                    Piso newFloor = new Piso(antiguedad, precioBase, nroPiso, direccion);
                    MessageBox.Show("El precio del Piso de " + newFloor.Direccion + " es de: $" + newFloor.calcularPrecio());
                }
            }

            if (btnLocal.Checked)
            {

                int superficie = Convert.ToInt32(tbSuperficie.Text);
                String direccion = tbDireccion.Text;
                int antiguedad = Convert.ToInt32(tbEdad.Text);
                int precioBase = Convert.ToInt32(tbPrecio.Text);
                int nroVentanales = Convert.ToInt32(tbWinds.Text);

                if (validarVentanales() && validarSup() && validarEdad() && validarPrecio())
                {

                    Local newProp = new Local(antiguedad, precioBase, superficie, nroVentanales, direccion); ;
                    MessageBox.Show("El precio del Local de " + newProp.Direccion + " es de: $" + newProp.calcularPrecio());
                }
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPiso_CheckedChanged(object sender, EventArgs e)
        {


            tbPiso.Enabled = true;

            tbSuperficie.Enabled = false;
            tbSuperficie.Text = null;
            tbWinds.Text = null;

            tbWinds.Enabled = false;

        }

        private void btnLocal_CheckedChanged(object sender, EventArgs e)
        {
            tbWinds.Enabled = true;

            tbSuperficie.Enabled = true;
            tbPiso.Text = null;

            tbPiso.Enabled = false;
        }
    
        //Validaciones

        private bool validarSopi()
        {
            try
            {
                int x = Convert.ToInt32(tbPiso.Text);
                lblPiso.ForeColor = Color.DarkGray;
                return true;
            }
            catch (Exception)
            {
                lblPiso.ForeColor = Color.OrangeRed;
                return false;
            }
        }
        private bool validarEdad()
        {
            try
            {
                int x = Convert.ToInt32(tbEdad.Text);
                lblEdad.ForeColor = Color.DarkGray;
                return true;
            }
            catch (Exception)
            {
                lblEdad.ForeColor = Color.OrangeRed;
                return false;
            }
        }

        private bool validarSup()
        {
            try
            {
                int x = Convert.ToInt32(tbSuperficie.Text);
                lblSup.ForeColor = Color.DarkGray;
                return true;
            }
            catch (Exception)
            {
                lblSup.ForeColor = Color.OrangeRed;
                return false;
            }
        }

        private bool validarVentanales()
        {
            try
            {
                int x = Convert.ToInt32(tbWinds.Text);
                lblWinds.ForeColor = Color.DarkGray;
                return true;
            }
            catch (Exception)
            {
                lblWinds.ForeColor = Color.OrangeRed;
                return false;
            }
        }

        private bool validarPrecio()
        {
            try
            {
                int x = Convert.ToInt32(tbPrecio.Text);
                lblPrecio.ForeColor = Color.DarkGray;
                return true;
            }
            catch (Exception)
            {
                lblPrecio.ForeColor = Color.OrangeRed;
                return false;
            }
        }
    }


}

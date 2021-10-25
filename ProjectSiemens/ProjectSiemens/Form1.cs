using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSiemens
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        List<Electrodomestico> listaElectro = new List<Electrodomestico>();




        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_Telesivor_CheckedChanged(object sender, EventArgs e)
        {
            tb_Carga.Enabled = false;
            tb_Resolu.Enabled = true;
            rb_SintoSi.Enabled = true;
            rb_SintoNo.Enabled = true;
            tb_Carga.Text = null; //vacia carga
        }

        private void rb_Lavadora_CheckedChanged(object sender, EventArgs e)
        {
            tb_Carga.Enabled = true;
            rb_SintoSi.Enabled = false;
            rb_SintoNo.Enabled = false;
            tb_Resolu.Enabled = false;
            tb_Resolu.Text = null; // vacía resolucion
        }

        private void rb_Electrodomestico_CheckedChanged(object sender, EventArgs e)
        {
            tb_Carga.Enabled = false;
            tb_Resolu.Enabled = false;
            rb_SintoSi.Enabled = false;
            rb_SintoNo.Enabled = false;

            tb_Carga.Text = null;
            tb_Resolu.Text = null;
        }

        private void but_CalculadorSupremo_Click(object sender, EventArgs e)
        {
            if (rb_Lavadora.Checked) // ingresar lavadero
            {
                if (compConstructores())
                {
                    listaElectro.Add(new Lavadora());

                    lbl_status.Text = "Lavadora por defecto!";
                    lbl_status.ForeColor = Color.Cyan;
                }
                else if (compPrecio())
                {
                    if (Double.TryParse(tb_Precio.Text, out double _precioElectro) && Double.TryParse(tb_Peso.Text, out double _pesoElectro))
                    {
                        listaElectro.Add(new Lavadora(_precioElectro, _pesoElectro));
                        lbl_status.Text = "Lavadora añadida con precio y peso.";
                    }
                    else
                    {
                        lbl_status.Text = "Error en el tipeo de un dato";
                        lbl_status.ForeColor = Color.LightCoral;
                    }
                }

                else
                {
                    if (char.TryParse(tb_Consumo.Text.ToUpper(), out char _consumoElectro) && Double.TryParse(tb_Peso.Text, out double _pesoElectro)
                        && Double.TryParse(tb_Precio.Text, out double _precioElectro) && int.TryParse(tb_Carga.Text, out int _cargaLava))
                    {
                        listaElectro.Add(new Lavadora(_precioElectro, _pesoElectro, tb_Color.Text, _consumoElectro, _cargaLava));
                        lbl_status.Text = "Lavadora añadida!";
                        lbl_status.ForeColor = Color.Cyan;
                    }
                    else
                    {
                        lbl_status.Text = "Error en el tipeo de un dato!";
                        lbl_status.ForeColor = Color.LightCoral;
                    }
                }
            }

            if (rb_Telesivor.Checked)
            {
                if (compConstructores())
                {
                    listaElectro.Add(new Televisor());
                    lbl_status.ForeColor = Color.Cyan;
                    lbl_status.Text = "Añadido por defecto!";
                }
                else if (compPrecio())
                {
                    if (Double.TryParse(tb_Peso.Text, out double _pesoElectro)
                        && Double.TryParse(tb_Precio.Text, out double _precioElectro))
                    {
                        listaElectro.Add(new Televisor(_precioElectro, _pesoElectro));
                        lbl_status.ForeColor = Color.Cyan;
                        lbl_status.Text = "Televisor añadido por Precio y Peso.";
                    }
                    else
                    {
                        lbl_status.ForeColor = Color.LightCoral;
                        lbl_status.Text = "Error de tipeo de un dato!";
                    }
                }
                else
                {

                    if (char.TryParse(tb_Consumo.Text.ToUpper(), out char _consumoElectro) && Double.TryParse(tb_Peso.Text, out double _pesoElectro)
                        && Double.TryParse(tb_Precio.Text, out double _precioElectro) && int.TryParse(tb_Resolu.Text, out int _resTV))
                    {
                        bool sinto = false;
                        if (rb_SintoSi.Checked)
                        {
                            sinto = true;
                        }
                        else if (rb_SintoNo.Checked)
                        {
                            sinto = false;
                        }
                        listaElectro.Add(new Televisor(_resTV, sinto, _precioElectro, _pesoElectro, tb_Color.Text, _consumoElectro));
                        lbl_status.ForeColor = Color.Cyan;
                        lbl_status.Text = "Televisor añadido.";
                    }
                }
            }

            if (rb_Electrodomestico.Checked)
            {
                if (compConstructores())
                {
                    listaElectro.Add(new Electrodomestico());
                    lbl_status.ForeColor = Color.DarkCyan;
                    lbl_status.Text = "Electrodomestico añadido por defecto!";

                }
                else if (compPrecio())
                {
                    if (Double.TryParse(tb_Peso.Text, out double _pesoElectro)
                        && Double.TryParse(tb_Precio.Text, out double _precioElectro))
                    {
                        listaElectro.Add(new Electrodomestico(_precioElectro, _pesoElectro));
                        lbl_status.ForeColor = Color.DarkCyan;
                        lbl_status.Text = "Añadido por precio y peso!";
                    }
                    else
                    {
                        lbl_status.ForeColor = Color.LightCoral;
                        lbl_status.Text = "Error de tipeo en el dato!";
                    }
                }

                {
                    if (char.TryParse(tb_Consumo.Text.ToUpper(), out char _consumoElectro) && Double.TryParse(tb_Peso.Text, out double _pesoElectro)
                        && Double.TryParse(tb_Precio.Text, out double _precioElectro))
                    {
                        listaElectro.Add(new Electrodomestico(_precioElectro, _pesoElectro, tb_Color.Text, _consumoElectro));
                        lbl_status.ForeColor = Color.DarkCyan;
                        lbl_status.Text = "Añadido!";
                    }
                    else
                    {
                        lbl_status.ForeColor = Color.LightCoral;
                        lbl_status.Text = "Error de tipeo en el dato!";
                    }
                }
            }
        }

        public Boolean compConstructores()
        {
            Boolean vacio;

            if (String.IsNullOrEmpty(tb_Precio.Text) && String.IsNullOrEmpty(tb_Peso.Text) && String.IsNullOrEmpty(tb_Color.Text) && String.IsNullOrEmpty(tb_Consumo.Text))
            {

                vacio = true;

            }
            else
            {

                vacio = false;

            }
            if (vacio)
            {
                if (rb_Lavadora.Checked == true)
                {
                    if (String.IsNullOrEmpty(tb_Carga.Text))
                    {
                        vacio = true;
                    }
                    else
                    {
                        vacio = false;
                    }
                }

                if (rb_Telesivor.Checked == true)
                {
                    if (String.IsNullOrEmpty(tb_Resolu.Text) && !rb_SintoNo.Checked && !rb_SintoSi.Checked)
                    {
                        vacio = true;
                    }
                    else
                    {
                        vacio = false;
                    }

                }
            }

            return vacio;
        }

        public Boolean compPrecio()
        {
            if (String.IsNullOrEmpty(tb_Precio.Text) && String.IsNullOrEmpty(tb_Peso.Text))
            {
                return false;
            }
            else
            {
                if (String.IsNullOrEmpty(tb_Color.Text) && String.IsNullOrEmpty(tb_Consumo.Text) &&
                    String.IsNullOrEmpty(tb_Carga.Text) && String.IsNullOrEmpty(tb_Resolu.Text) &&
                    !rb_SintoNo.Checked && !rb_SintoSi.Checked)
                {
                    if (String.IsNullOrEmpty(tb_Peso.Text))
                    {
                        return true;
                    }
                    else
                    {
                        tb_Peso.Text = "¡Error!";
                        return false;
                    }

                    if (!String.IsNullOrEmpty(tb_Peso.Text))
                    {
                        if (!String.IsNullOrEmpty(tb_Peso.Text))
                        {
                            return true;
                        }
                        else
                        {
                            tb_Precio.Text = "¡Error!";
                            return false;
                        }
                    }
                }

                else
                {
                    return false;
                }
            }

        }


        private void mostrarCarrito()
        {

            lb_ListaArticulos.Text = "Lista actual: " + listaElectro.Count + " Artículo(s).";
            

        }

        private void mostrarCosto()
        {
            double precioLavadero = 0;
            double precioTele = 0;
            double precioElectrodo = 0;

            double costoFinal = 0;
            foreach (Electrodomestico e in listaElectro)
            {

                e.PrecioFinal();
                precioElectrodo += e._precioElectro;

                if (e is Lavadora)
                {
                    precioLavadero += e._precioElectro;
                }else if(e is Televisor)
                {
                    precioTele += e._precioElectro;
                }
            }

            lb_Precio.Text = "Precio lavadero: $ " + precioLavadero + "\r\nPrecio televisores: $"
                + precioTele + "\r\nPrecio TODOS: $" + precioElectrodo;

        }

        private void tb_Carga_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarCarrito();
            mostrarCosto();
        }
    }
}

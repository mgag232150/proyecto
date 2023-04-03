using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto003
{
    public partial class pago1 : Form
    {
        double precio = 0;
        public pago1()
        {
            InitializeComponent();
        }

        private void pago1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("c");
        }

        private void edad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProductos.Text;

            if (producto.Equals("Tercera edad")) precio = 3.90;
            if (producto.Equals("Adulto")) precio = 5.00;

            lblPrecio.Text = precio.ToString("c");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (cboProductos.SelectedIndex == -1) 
                MessageBox.Show("Debe seleccionar una edad...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe seleccionar el numero de boletos...!!!");
            else
            {
                // caturaando datos 
                string producto = cboProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                //Procesar calculos 
                double subtotal = cantidad * precio;

                double precioFinal = subtotal ;
                //Imprecion de resultado
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(precioFinal.ToString());

                lvVenta.Items.Add(fila);
                btnCancelar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboProductos.Text = "(seleccine edad)";
            cboTipo.Text = "(selecione tipo de pago)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("c");
            cboProductos.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasica clasica = new clasica();
            this.Hide();
            clasica.Show();
        }

        private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            butacas1 butacas1 = new butacas1();
            this.Hide();
            butacas1.Show();
        }
    }
}

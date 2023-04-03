using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace proyecto003
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nombre.Clear();
            Direccion.Clear();
            DUI.Clear();
            Telefono.Clear();
            Correo.Clear();
            Usuario.Clear();
            Contraseña.Clear();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
          if(Nombre.Text == "Jeferson Wilfredo Cruz Hernandez"
             && Direccion.Text == "Santiago"
             && DUI.Text == "123-4"
             && Telefono.Text == "79614845"
             && Correo.Text == "jeferson@gmail.com"
             && Usuario.Text == "wil26"
             && Contraseña.Text == "12345")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
          }
          else
          {
                MessageBox.Show("Los datos ingresados son incorrectos");  
          }
        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

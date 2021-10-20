using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionexamennoviembre
{
    sjbckuwe
    public partial class Form1 : Form
    {
        string[] nombre = new string[100];
        string[] apellido = new string[100];
        string[] correo = new string[100];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bpresione_Click(object sender, EventArgs e)
        {
            int edad_usuario;

            for (int i = 0; i <= 100; i++)
            {
                edad_usuario = System.Convert.ToInt32(txtedad.Text);
                if (edad_usuario >= 18)
                {
                    LBLresultado.Text = "puede ingresar a la capacitacion...continue";
                }
                else if (edad_usuario >= 1 && edad_usuario < 18)
                {
                    LBLresultado.Text = "no puede ingresar a la capacitacion...";
                }
                txtnombre.Text = "";
                txtedad.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bcargar_Click(object sender, EventArgs e)
        {
            Integrantes integrantesacargar = new Integrantes();


            integrantesacargar.Nombre = txtnombre.Text;
            integrantesacargar.Apellido = txtapellido.Text;
            integrantesacargar.Correo = txtcorreo.Text;
            integrantesacargar.edad = System.Convert.ToInt32(txtedad.Text);

            integrantesacargar = null;
            integrantesacargar = new Integrantes();
        }
    }
}

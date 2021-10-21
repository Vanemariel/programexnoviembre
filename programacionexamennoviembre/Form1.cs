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

    public partial class Form1 : Form
    {
        int pos = 0;
        string[] nuevosnombres = new string[50];
        string[] nuevosapellidos = new string[50];
        string[] nuevoscorreos = new string[50];
        string[] nuevaedad = new string[50];
       

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

            for (int i = 0; i <= 50; i++)
            {
                edad_usuario = System.Convert.ToInt32(txtedad.Text);
                if (edad_usuario >= 18)
                {
                    LBLresultado.Text = "PUEDE INGRESAR A LA CAPACITACION...CONTINUE";
                }
                else if (edad_usuario >= 1 && edad_usuario < 18)
                {
                    LBLresultado.Text = "NO PUEDE INGRESAR A LA CAPACITACION...";
                }
                txtnombre.Text = "";
                txtedad.Text = "";
                txtapellido.Text = "";
                txtcorreo.Text = "";


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bcargar_Click(object sender, EventArgs e)
        {
            Integrantes integrantesacargar = new Integrantes();

            pos = pos + 1;

            //integrantesacargar.Nombre = txtnombre.Text;
            //integrantesacargar.Apellido = txtapellido.Text;
            //integrantesacargar.Correo = txtcorreo.Text;
            //integrantesacargar.edad = System.Convert.ToInt32(txtedad.Text);
            nuevosnombres[pos] = txtnombre.Text;
            nuevosapellidos[pos] = txtapellido.Text;
            nuevoscorreos[pos] = txtcorreo.Text;
            nuevaedad[pos] = txtedad.Text;





        }

        private void Blista_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Bborrar_Click(object sender, EventArgs e)
        {

        }
    }
}

using programacionexamennoviembre.clases;
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
        Integrantes Ingre = new Integrantes();
        public Personascargadas listas { get; set; } = new Personascargadas();
        //int pos = 0;
        //string[] nuevosnombres = new string[50];
        //string[] nuevosapellidos = new string[50];
        //string[] nuevoscorreos = new string[50];
        //string[] nuevaedad = new string[50];
       

        public Form1()
        {
            InitializeComponent();

            dgv.DataSource = listas.DT;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bpresione_Click(object sender, EventArgs e)
        {
            
            int edad_usuario = System.Convert.ToInt32(txtedad.Text);
            for (int i = 0; i <= 50; i++)
            {
                
                if (edad_usuario >= 18)
                {
                  
                       LBLresultado.Text = "PUEDE INGRESAR A LA CAPACITACION...";
                    
                }
                else if (edad_usuario >=1 && edad_usuario <18)
                {
                    LBLresultado.Text = "NO PUEDE INGRESAR A LA CAPACITACION...CONTINUE";
                }
                

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bcargar_Click(object sender, EventArgs e)
        {
            //Integrantes integrantesacargar = new Integrantes();

            //pos = pos + 1;
            //integrantesacargar.Nombre = txtnombre.Text;
            //integrantesacargar.Apellido = txtapellido.Text;
            //integrantesacargar.Correo = txtcorreo.Text;
            //integrantesacargar.edad = System.Convert.ToInt32(txtedad.Text);
            //nuevosnombres[pos] = txtnombre.Text;
            //nuevosapellidos[pos] = txtapellido.Text;
            //nuevoscorreos[pos] = txtcorreo.Text;
            //nuevaedad[pos] = txtedad.Text;
            Ingre.Nombre = txtnombre.Text;
            Ingre.Apellido = txtapellido.Text;
            Ingre.Correo = txtcorreo.Text;
            Ingre.edad = Convert.ToInt32(txtedad.Text);
            


            if (!listas.UpdateIntegrantes(Ingre))
            {
                txtedad.Focus();
                txtedad.SelectAll();
                Blista.Text = "Ingresante Invalido";
            }
            
            Ingre = new Integrantes();
            //txtnombre.Text = "";
            //txtedad.Text = "";
            //txtapellido.Text = "";
            //txtcorreo.Text = "";

        }

        private void Blista_Click(object sender, EventArgs e)
        {
        //    lbllista.Text = "lista:\r\n";
        //    foreach (Integrantes item in Integrantes)
                
        //    {
        //        lbllista.Text = lbllista.Text + item.Nombre + item.edad.ToString() + item.Apellido + item.Correo;
        //    }

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Bborrar_Click(object sender, EventArgs e)
        {
            if (listas.DeleteIntegrantes(Ingre))
            {
                limpiar();
            }
            //else
            //{
            //    Blista.Text = "El registro" + Ingre.Nombre + "no puede borrarse";
            //}
            Ingre = new Integrantes();
        }
        private void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcorreo.Text = ""; ;
            txtedad.Text = "";


        }
           


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbllista_Click(object sender, EventArgs e)
        {

        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

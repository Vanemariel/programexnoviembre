using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionexamennoviembre
{
    public class Integrantes
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int edad { get; set; }


        public bool Validar()
        {
            bool respuesta = false;

            if (edad > 18 && edad < 70)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }

       
}

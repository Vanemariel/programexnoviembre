using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionexamennoviembre.clases
{
    public class Personascargadas
    {
        //Integrantes[] Integrantes { get; set; }

        public DataTable DT { get; set; } = new System.Data.DataTable();
        public int ultimoId { get; set; } = 0;
        public Personascargadas()

        {
            DT.TableName = "Personascargadas";
            DT.Columns.Add("Id");
            DT.Columns.Add("Nombres");
            DT.Columns.Add("Apellido");
            DT.Columns.Add("Correo");
            DT.Columns.Add("Edad");

            leerDT_Carpetaingresantes();
        }

        public void leerDT_Carpetaingresantes()
        {
            if (System.IO.File.Exists("lista.xml"))
            {
                DT.ReadXml("lista.xml");
                ultimoId = 0;
                for (int i = 0; i < DT.Rows.Count; i++)

                {
                    if (Convert.ToInt32(DT.Rows[i]["Id"]) > ultimoId)

                    {
                        ultimoId = Convert.ToInt32(DT.Rows[i]["Id"]);
                    }

                }
            }
        }
        public bool UpdateIntegrantes( Integrantes integrantes)
        {     
            bool respuesta = integrantes.Validar();

            if (respuesta)
            {
                if (integrantes.id == 0)
                {
                    ultimoId = ultimoId + 1;
                    integrantes.id = ultimoId;

                    DT.Rows.Add();
                    int NumeroRegistroNuevo = DT.Rows.Count - 1;

                    DT.Rows[NumeroRegistroNuevo]["Id"] = integrantes.id.ToString();
                    DT.Rows[NumeroRegistroNuevo]["Nombres"] = integrantes.Nombre;
                    DT.Rows[NumeroRegistroNuevo]["Apellido"] = integrantes.Apellido;
                    DT.Rows[NumeroRegistroNuevo]["Correo"] = integrantes.Correo;
                    DT.Rows[NumeroRegistroNuevo]["edad"] = integrantes.edad.ToString();

                    DT.WriteXml("Lista.xml");
                }
                else
                {
                    for (int fila = 0; fila<DT.Rows.Count; fila++)
                    {
                        if (Convert.ToInt32(DT.Rows[fila]["Id"]) == integrantes.id)
                        {
                            DT.Rows[fila]["Nombre"] = integrantes.Nombre;
                            DT.Rows[fila]["Apellido"] = integrantes.Apellido;
                            DT.Rows[fila]["correo"] = integrantes.Correo;
                            DT.Rows[fila]["edad"] = integrantes.edad.ToString();
                            DT.WriteXml("Lista.xml");
                            break;
                        }
                    }
                }
            }
            return respuesta;
        }
	
	}
	       
}
        

    

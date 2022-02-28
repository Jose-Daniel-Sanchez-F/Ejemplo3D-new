using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3D
{
    internal class Persona
    { 
        /*esto nunca va , solo es de referencia para escribir lo de abajo 
        string dpi;
        string nombre;
        string apellido;
        string telefono;*/

        //Propiedades: 
        public string Dpi { get; set; }
        public string Nombre { get; set; }  
        public string Apellido{ get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //metodos:

        public int edad()
        {
           
            DateTime hoy =DateTime.Now; //PARA OBTENER LA EDAD

            //aca se debe calcular la edad
            return (20);

        }









    }
}

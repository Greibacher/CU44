using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    public class Estado
    {
        private string nombre;
        
        public Estado(string nombreEstado) 
        {
            this.nombre = nombreEstado;
        }

        public bool esFinalizada()
        {
            return (nombre == "Finalizada");
        }
        public bool esIniciada()
        {
            return (nombre == "Iniciada");
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }



    }
}

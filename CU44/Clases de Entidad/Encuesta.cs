using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{

    public class Encuesta
    {
        private string descripcion;
        private DateTime fechaFinVigencia;
        private List<Pregunta> pregunta;

        public Encuesta(string desc, DateTime fechaFin) 
        {
            this.descripcion = desc;
            this.fechaFinVigencia = fechaFin;
            this.pregunta = new List<Pregunta>();
        }

        public void agregarPregunta(Pregunta nuevaPregunta) 
        {
            pregunta.Add(nuevaPregunta);
        }

        public bool esVigente(DateTime fechaActual) 
        {
            return (fechaActual < fechaFinVigencia);
        }

        public string armarEncuesta() 
        {
            return "a"; //no supe como implementarlo
        }

        public string getDescripcionEncuesta 
        {
            get => descripcion;
            set => descripcion = value;
        }

    }
}

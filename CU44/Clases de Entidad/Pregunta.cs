using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    public class Pregunta
    {
        private string pregunta;
        private List<RespuestaPosible> respuesta;
        public Pregunta(string preg) 
        { 
            this.pregunta = preg;
            this.respuesta = new List<RespuestaPosible>();
        }

        public void agregarRespuesta(RespuestaPosible rta)
        {
            respuesta.Add(rta);
        }

        public string ListarRespuestasPosibles()
        {
            StringBuilder cadena = new StringBuilder();

            foreach (RespuestaPosible respuestaInd in respuesta)
            {
                cadena.AppendLine(respuestaInd.getValorRta);
            }

            return cadena.ToString();
        }

    }
}

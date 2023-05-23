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
        private List<RespuestaPosible> respuestasPosibles;
        public Pregunta(string preg) 
        { 
            this.pregunta = preg;
            this.respuestasPosibles = new List<RespuestaPosible>();
        }

        public void agregarRespuesta(RespuestaPosible rta)
        {
            if(!respuestasPosibles.Contains(rta)) respuestasPosibles.Add(rta);
        }

        public string ListarRespuestasPosibles()
        {
            StringBuilder cadena = new StringBuilder();

            foreach (RespuestaPosible respuestaInd in respuestasPosibles)
            {
                cadena.AppendLine(respuestaInd.getValor());
            }

            return cadena.ToString();
        }

        public string getPregunta()
        {
            return pregunta;
        }

        public List<RespuestaPosible> getRespuestaPosible()
        {
            return respuestasPosibles;
        }

    }
}

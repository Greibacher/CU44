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
        private List<RespuestaPosible> posiblesRespuestas;
        public Pregunta(string preg) 
        { 
            this.pregunta = preg;
            this.posiblesRespuestas = new List<RespuestaPosible>();
        }

        public void agregarRespuesta(RespuestaPosible rta)
        {
            if(!posiblesRespuestas.Contains(rta))posiblesRespuestas.Add(rta);
        }

        public string ListarRespuestasPosibles()
        {
            StringBuilder cadena = new StringBuilder();

            foreach (RespuestaPosible respuestaInd in posiblesRespuestas)
            {
                cadena.AppendLine(respuestaInd.getValor());
            }

            return cadena.ToString();
        }

    }
}

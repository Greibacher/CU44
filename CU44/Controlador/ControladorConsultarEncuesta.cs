using CU44.Clases_de_Entidad;
using System;
using System.Collections.Generic;

namespace CU44.Controlador
{
    class ControladorConsultarEncuesta
    {
        private DateTime fechaInicio, fechaFin;

        public ControladorConsultarEncuesta()
        {
        }

        public Encuesta consultarEncuesta()
        {
            return new Encuesta("jaja", DateTime.Now);
        }
        public void tomarDatosPeriodoLlamada(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public List<Llamada> buscadarLlamadasRespondidas()
        {
            List<Llamada> llamadas = new List<Llamada>();
            
            List<Llamada> llamadasTodasLasLlamadas = Llamada.traerTodasLasLlamadas();
            foreach (Llamada llamada in llamadasTodasLasLlamadas)
            {
                if (llamada.esDePeriodo(fechaInicio, fechaInicio) && llamada.tieneRespuestas())
                {
                    llamadas.Add(llamada);
                }
            }


            return llamadas;
        }
    }
}

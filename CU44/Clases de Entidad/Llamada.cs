using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    class Llamada
    {
        private int duracion;
        private List<CambioEstado> cambios;
        private List<RespuestaDeCliente> respuestaDeClientes;

        public Llamada()
        {
        }

        public Llamada(int duracion)
        {
            duracion = duracion;
        }

        public static List<Llamada> traerTodasLasLlamadas()
        {
            List<Llamada> llamadas = new List<Llamada>();
            return llamadas;
        }

        public CambioEstado buscarCambioEstadoInicial()
        {
            CambioEstado cE = default;
            foreach (CambioEstado cambio in cambios)
            {
                if (cambio.esEstadoInicial())
                {
                    cE = cambio;
                    break;
                }
            }
            return cE;
        }
        public CambioEstado buscarCambioEstadoFinal()
        {
            CambioEstado cE = default;
            foreach (CambioEstado cambio in cambios)
            {
                if (cambio.esEstadoFinalizada())
                {
                    cE = cambio;
                    break;
                }
            }
            return cE;
        }

        public Boolean esDePeriodo(DateTime fechaInicio, DateTime fechaFinal)
        {
            CambioEstado inicial = buscarCambioEstadoInicial(), final = buscarCambioEstadoFinal();
            DateTime fechaHoraComienzoLlamado = inicial.getFechaHoraInicio(), fechaHoraFinLlamado = final.getFechaHoraFin();
            Boolean estaEnPeriodo = fechaHoraComienzoLlamado.CompareTo(fechaInicio) >= 0;
            estaEnPeriodo = estaEnPeriodo && fechaHoraFinLlamado.CompareTo(fechaFinal) <= 0;
            return estaEnPeriodo;
        }

        public Boolean tieneRespuestas()
        {

            return true;
        }
    }
}

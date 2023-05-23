using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    class Llamada
    {
        private int? duracion;
        private List<CambioEstado> cambiosEstado;
        private List<RespuestaDeCliente> respuestasDeClientes;
        private Cliente cliente;

        

        public Llamada(Cliente cliente) 
        {
        this.duracion = null;
        this.cambiosEstado = new List<CambioEstado>();
        this.respuestasDeClientes = new List<RespuestaDeCliente>();
        this.cliente = cliente;
        }

        public static List<Llamada> traerTodasLasLlamadas()
        {
            List<Llamada> llamadas = new List<Llamada>();
            return llamadas;
        }

        public void agregarCambioEstado(CambioEstado cambioEstado) 
        {
            cambiosEstado.Add(cambioEstado);
            if(this.duracion == null) { this.duracion = this.calcularDuracion();  }
            
        }

        public void agregarRespuestaDeCliente(RespuestaDeCliente respuestaDeCliente) 
        {
            respuestasDeClientes.Add(respuestaDeCliente);
        }

        public CambioEstado buscarCambioEstadoInicial()
        {
            CambioEstado cE = default;
            foreach (CambioEstado cambio in cambiosEstado)
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
            foreach (CambioEstado cambio in cambiosEstado)
            {
                if (cambio.esEstadoFinalizada())
                {
                    cE = cambio;
                    break;
                }
            }
            return cE;
        }

        public int? calcularDuracion() 
        {
            CambioEstado estadoInicial = this.buscarCambioEstadoInicial();
            CambioEstado estadoFinal = this.buscarCambioEstadoFinal();
            if (estadoInicial != default || estadoFinal != default) {
            //TimeSpan diferencia = estadoFinal.getFechaHoraFin().Subtract(estadoInicial.getFechaHoraInicio());
            //int minutos = (int)diferencia.TotalMinutes;
            return 5;
            }
            return null;
            
        }

        public Boolean esDePeriodo(DateTime fechaInicio, DateTime fechaFinal)
        {
            CambioEstado inicial = buscarCambioEstadoInicial(), final = buscarCambioEstadoFinal();
            DateTime fechaHoraComienzoLlamado = inicial.getFechaHoraInicio(), fechaHoraFinLlamado = final.getFechaHoraInicio();
            Boolean estaEnPeriodo = fechaHoraComienzoLlamado.CompareTo(fechaInicio) >= 0;
            estaEnPeriodo = estaEnPeriodo && fechaHoraFinLlamado.CompareTo(fechaFinal) <= 0;
            return estaEnPeriodo;
        }
        public int? getDuracion
        {
            get => duracion;
            set => duracion = value;
        }

        public Boolean tieneRespuestas()
        {

            return true;
        }
    }
}

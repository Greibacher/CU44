using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private DateTime? fechaHoraFin;
        private Estado estado;

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        public DateTime getFechaHoraInicio
        {
            get => fechaHoraInicio;
            set => fechaHoraInicio = value;
        }
        public DateTime? getFechaHoraFin
        {
            get => fechaHoraFin;
            set => fechaHoraFin = value;
        }

        public string getNombreEstado
        {
            get => (estado.getNombre);
            set => (estado.getNombre) = value;
        }
        public bool esEstadoInicial()
        {
            return estado.esIniciada();
        }
        public bool esEstadoFinalizada()
        {
            return estado.esFinalizada();
        }



        public bool obtenerEstadoActual()
        {
            return (fechaHoraFin != null);
        }
    }
}

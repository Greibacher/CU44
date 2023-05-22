using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    public class RespuestaDeCliente
    {
        private DateTime fechaEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        public RespuestaDeCliente(DateTime fecha, RespuestaPosible respuesta )
        {
            this.fechaEncuesta = fecha;
            this.respuestaSeleccionada = respuesta;

        }
        public DateTime FechaEncuesta
        {
            get => fechaEncuesta;
            set => fechaEncuesta = value;
        }

        public string DescripcionRta
        {
            get => respuestaSeleccionada.getDescripcion();
            set => respuestaSeleccionada.setDescripcion(value);
        }
     }
}

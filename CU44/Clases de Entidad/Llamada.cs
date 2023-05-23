using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU44.Clases_de_Entidad
{
    class Llamada
    {
        private int? duracion;
        private List<CambioEstado> cambiosEstado;
        private List<RespuestaDeCliente> respuestasDeClientes;
        private Cliente cliente;
        private Encuesta encuestaLlamada;

        

        public Llamada(Cliente cliente, Encuesta encuesta) 
        {
        this.duracion = null;
        this.cambiosEstado = new List<CambioEstado>();
        this.respuestasDeClientes = new List<RespuestaDeCliente>();
        this.cliente = cliente;
        this.encuestaLlamada = encuesta;
        }

        public static List<Llamada> traerTodasLasLlamadas()
        {
            List<Llamada>llamadas = new List<Llamada>();
            //respuestas
            RespuestaPosible respuestaPosible2Pregunta1 = new RespuestaPosible("El servicio fue malo", "Malo");
            RespuestaPosible respuestaPosible3Pregunta1 = new RespuestaPosible("El servicio fue normal", "Normal");
            RespuestaPosible respuestaPosible1Pregunta1 = new RespuestaPosible("El servicio fue bueno", "Bueno");

            RespuestaPosible respuestaPosible2Pregunta2 = new RespuestaPosible("La atencion fue mala", "1");
            RespuestaPosible respuestaPosible3Pregunta2 = new RespuestaPosible("La atencion fue normal", "2");
            RespuestaPosible respuestaPosible1Pregunta2 = new RespuestaPosible("La atencion fue buena", "3");
            RespuestaPosible respuestaPosible4Pregunta2 = new RespuestaPosible("La atencion fue muy buena", "4");
            RespuestaPosible respuestaPosible5Pregunta2 = new RespuestaPosible("La atencion fue excelente", "5");

            //preguntas con sus respuestas
            Pregunta pregunta1 = new Pregunta("Que tan util le parecio el servicio?");
            pregunta1.agregarRespuesta(respuestaPosible1Pregunta1);
            pregunta1.agregarRespuesta(respuestaPosible2Pregunta1);
            pregunta1.agregarRespuesta(respuestaPosible3Pregunta1);

            Pregunta pregunta2 = new Pregunta("Como Calificaria la atencion del 1 al 5?");
            pregunta2.agregarRespuesta(respuestaPosible1Pregunta2);
            pregunta2.agregarRespuesta(respuestaPosible2Pregunta2);
            pregunta2.agregarRespuesta(respuestaPosible3Pregunta2);
            pregunta2.agregarRespuesta(respuestaPosible4Pregunta2);
            pregunta2.agregarRespuesta(respuestaPosible5Pregunta2);

            //encuentas con sus preguntas
            Encuesta encuesta = new Encuesta("Encuesta de satisfacción en la atención telefónica", DateTime.Now.AddMinutes(20));
            encuesta.agregarPregunta(pregunta1);
            encuesta.agregarPregunta(pregunta2);

            //creacion del cliente
            Cliente cliente1 = new Cliente(44194683, "Isauro Rodriguez", 351233699);
            Cliente cliente2 = new Cliente(42478741, "Valentin Tarquinio", 351263799);
            Cliente cliente3 = new Cliente(43541546, "Martin Mengo", 351274840);
            Cliente cliente4 = new Cliente(43891510, "Joaquin Figueredo", 351014741);

            //respuestas del cliente -- respuestas dentro del periodo
            RespuestaDeCliente respuesta1DeCliente1 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-25), respuestaPosible1Pregunta1);
            RespuestaDeCliente respuesta2DeCliente1 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-26), respuestaPosible2Pregunta2);

            RespuestaDeCliente respuesta1DeCliente2 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-26), respuestaPosible2Pregunta1);
            RespuestaDeCliente respuesta2DeCliente2 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-26), respuestaPosible2Pregunta2);

            RespuestaDeCliente respuesta1DeCliente3 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-26), respuestaPosible2Pregunta1);
            RespuestaDeCliente respuesta2DeCliente3 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-26), respuestaPosible4Pregunta2);

            //respuesta llamada fuera de periodo
            RespuestaDeCliente respuestaDeCliente3 = new RespuestaDeCliente(new DateTime(2021, 8, 15), respuestaPosible2Pregunta2);

            //armado de la llamada
            Llamada llamada1 = new Llamada(cliente1, encuesta);
            llamada1.agregarRespuestaDeCliente(respuesta1DeCliente1);
            llamada1.agregarRespuestaDeCliente(respuesta2DeCliente1);

            Llamada llamada2 = new Llamada(cliente2, encuesta);
            llamada2.agregarRespuestaDeCliente(respuesta1DeCliente2);
            llamada2.agregarRespuestaDeCliente(respuesta2DeCliente2);

            Llamada llamada3 = new Llamada(cliente3, encuesta);
            llamada3.agregarRespuestaDeCliente(respuesta1DeCliente3);
            llamada3.agregarRespuestaDeCliente(respuesta2DeCliente3);

            Llamada llamada4 = new Llamada(cliente4, encuesta);

            //armado de estados
            Estado cancelada = new Estado("Cancelada");
            Estado finalizada = new Estado("Finalizada");
            Estado escuchada = new Estado("Escuchada");
            Estado seleccionada = new Estado("Seleccionada");
            Estado descartada = new Estado("Descartada");
            Estado enCurso = new Estado("En Curso");
            Estado iniciada = new Estado("Iniciada");

            //armado cambios de estado
            CambioEstado cambioEstado1Llamada1 = new CambioEstado(DateTime.Now.AddMinutes(-44), DateTime.Now.AddMinutes(-35), iniciada);
            CambioEstado cambioEstado2Llamada1 = new CambioEstado(DateTime.Now.AddMinutes(-33), DateTime.Now.AddMinutes(-20), enCurso);
            CambioEstado cambioEstado3Llamada1 = new CambioEstado(DateTime.Now.AddMinutes(-26), null, finalizada);

            CambioEstado cambioEstado1Llamada2 = new CambioEstado(DateTime.Now.AddMinutes(-40).AddDays(-30), DateTime.Now.AddMinutes(-35).AddDays(-30), iniciada);
            CambioEstado cambioEstado2Llamada2 = new CambioEstado(DateTime.Now.AddMinutes(-30).AddDays(-30), DateTime.Now.AddMinutes(-20).AddDays(-30), enCurso);
            CambioEstado cambioEstado3Llamada2 = new CambioEstado(DateTime.Now.AddMinutes(-20).AddDays(-30), null, finalizada);

            CambioEstado cambioEstado1Llamada3 = new CambioEstado(new DateTime(2021, 8, 15).AddMinutes(-80), new DateTime(2021, 8, 15).AddMinutes(-75), iniciada);
            CambioEstado cambioEstado2Llamada3 = new CambioEstado(new DateTime(2021, 8, 15).AddMinutes(-70), new DateTime(2021, 8, 15).AddMinutes(-50), enCurso);
            CambioEstado cambioEstado3Llamada3 = new CambioEstado(new DateTime(2021, 8, 15).AddMinutes(-40), null, finalizada);

            CambioEstado cambioEstado1Llamada4 = new CambioEstado(new DateTime(2021, 8, 23).AddMinutes(-64), new DateTime(2021, 8, 23).AddMinutes(-60), iniciada);
            CambioEstado cambioEstado2Llamada4 = new CambioEstado(new DateTime(2021, 8, 23).AddMinutes(-23), new DateTime(2021, 8, 23).AddMinutes(-20), enCurso);
            CambioEstado cambioEstado3Llamada4 = new CambioEstado(new DateTime(2021, 8, 23).AddMinutes(-10), null, finalizada);

            //asignar cambios de estado a la llamada
            llamada1.agregarCambioEstado(cambioEstado1Llamada1);
            llamada1.agregarCambioEstado(cambioEstado2Llamada1);
            llamada1.agregarCambioEstado(cambioEstado3Llamada1);

            llamada2.agregarCambioEstado(cambioEstado1Llamada2);
            llamada2.agregarCambioEstado(cambioEstado2Llamada2);
            llamada2.agregarCambioEstado(cambioEstado3Llamada2);

            llamada3.agregarCambioEstado(cambioEstado1Llamada3);
            llamada3.agregarCambioEstado(cambioEstado2Llamada3);
            llamada3.agregarCambioEstado(cambioEstado3Llamada3);

            llamada4.agregarCambioEstado(cambioEstado1Llamada4);
            llamada4.agregarCambioEstado(cambioEstado2Llamada4);
            llamada4.agregarCambioEstado(cambioEstado3Llamada4);

            llamadas.Add(llamada1);
            llamadas.Add(llamada2);
            llamadas.Add(llamada3);
            llamadas.Add(llamada4);
            return llamadas;
        }

        public void agregarCambioEstado(CambioEstado cambioEstado) 
        {
            cambiosEstado.Add(cambioEstado);
            if(this.buscarCambioEstadoFinal() != default) { 
            if(this.duracion == null) { this.duracion = this.calcularDuracion();  }
            }
        }

        public string getNombreCliente() 
        {
            return cliente.getNombreCompleto();
        }

        public void agregarRespuestaDeCliente(RespuestaDeCliente respuestaDeCliente) 
        {
            respuestasDeClientes.Add(respuestaDeCliente);
        }

        public DateTime getFechaInicio()
        {
            return buscarCambioEstadoInicial().getFechaHoraInicio();
        }

        public DateTime getFechaFin()
        {
            return buscarCambioEstadoFinal().getFechaHoraInicio();
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

        public int calcularDuracion() 
        {
            CambioEstado estadoInicial = this.buscarCambioEstadoInicial();     
            CambioEstado estadoFinal = this.buscarCambioEstadoFinal();
            TimeSpan diferencia = estadoFinal.getFechaHoraInicio().Subtract(estadoInicial.getFechaHoraInicio());
            int minutos = (int)diferencia.TotalMinutes;
            return minutos;
            
        }

        public Boolean esDePeriodo(DateTime fechaInicio, DateTime? fechaFinal)
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
            return (respuestasDeClientes.Count > 0);
        }

        public Encuesta getEncuesta()
        {
            return encuestaLlamada;
        }

        public List<String> getDescripcionRespuestasDeClientes()
        {
            List<String> listaRta = new List<String>();
            foreach (RespuestaDeCliente respuesta in respuestasDeClientes)
            {
                listaRta.Add(respuesta.DescripcionRta);
            }
            return listaRta;
        }

        public List<RespuestaDeCliente> getRespuestaDeClientes()
        {
            return respuestasDeClientes;
        }

        internal string getNombreEstadoActual()
        {
            return buscarCambioEstadoFinal().getNombreEstado();
        }
    }
}

using CU44.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;

namespace CU44.Controlador
{
    class ControladorConsultarEncuesta
    {
        private DateTime fechaInicio, fechaFin;
        private PantallaConsultarEncuesta pantalla;
        private List<Llamada> llamadas;
        private Llamada llamadaSeleccionada;
        private List<Llamada> llamadasRespondidas;
        public ControladorConsultarEncuesta()
        {
            
        }
        public ControladorConsultarEncuesta(PantallaConsultarEncuesta v)
        {
            this.pantalla = v;
            llamadas = getAll();
            llamadasRespondidas = buscarLlamadasRespondidas();
        }

        public Encuesta consultarEncuesta()
        {
            return new Encuesta("jaja", DateTime.Now);
        }
        public List<Llamada> tomarDatosPeriodoLlamada(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            return buscarLlamadasRespondidas();
        }

        public List<Llamada> buscarLlamadasRespondidas()
        {
            foreach (Llamada llamada in llamadas)
            {
                if (llamada.esDePeriodo(fechaInicio, fechaFin) && llamada.tieneRespuestas())
                {
                    llamadasRespondidas.Add(llamada);
                }
            }


            return llamadasRespondidas;
        }

        public List<Llamada> getAll() 
        {
            llamadasRespondidas = new List<Llamada>();
            llamadas = new List<Llamada>();
            //respuestas
            RespuestaPosible respuestaPosible2Pregunta1 = new RespuestaPosible("El servicio fue malo", "Malo");
            RespuestaPosible respuestaPosible3Pregunta1 = new RespuestaPosible("El servicio fue normal", "Normal");
            RespuestaPosible respuestaPosible1Pregunta1 = new RespuestaPosible("El servicio fue bueno", "Bueno");

            RespuestaPosible respuestaPosible2Pregunta2 = new RespuestaPosible("La atencion fue mala", "Mala");
            RespuestaPosible respuestaPosible3Pregunta2 = new RespuestaPosible("La atencion fue normal", "Normal");
            RespuestaPosible respuestaPosible1Pregunta2 = new RespuestaPosible("La atencion fue buena", "Buena");

            //preguntas con sus respuestas
            Pregunta pregunta1 = new Pregunta("Que tan util le parecio el servicio?");
            pregunta1.agregarRespuesta(respuestaPosible1Pregunta1);
            pregunta1.agregarRespuesta(respuestaPosible2Pregunta1);
            pregunta1.agregarRespuesta(respuestaPosible3Pregunta1);

            Pregunta pregunta2 = new Pregunta("Que le parecio la atencion?");
            pregunta2.agregarRespuesta(respuestaPosible1Pregunta2);
            pregunta2.agregarRespuesta(respuestaPosible2Pregunta2);
            pregunta2.agregarRespuesta(respuestaPosible3Pregunta2);

            //encuentas con sus preguntas
            Encuesta encuesta = new Encuesta("Encuesta de satisfacción en la atención telefónica", DateTime.Now.AddMinutes(20));
            encuesta.agregarPregunta(pregunta1);
            encuesta.agregarPregunta(pregunta2);

            //creacion del cliente
            Cliente cliente1 = new Cliente(44194683, "Isauro Rodriguez", 351233699);
            Cliente cliente2 = new Cliente(44194683, "Valentin Tarquinio", 351233699);

            //respuestas del cliente -- respuestas dentro del periodo
            RespuestaDeCliente respuestaDeCliente1 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-25), respuestaPosible1Pregunta1);
            RespuestaDeCliente respuestaDeCliente2 = new RespuestaDeCliente(DateTime.Now.AddMinutes(-26), respuestaPosible2Pregunta2);

            //respuesta llamada fuera de periodo
            RespuestaDeCliente respuestaDeCliente3 = new RespuestaDeCliente(new DateTime(2021, 8, 15), respuestaPosible2Pregunta2);

            //armado de la llamada
            Llamada llamada1 = new Llamada(cliente1);
            llamada1.agregarRespuestaDeCliente(respuestaDeCliente1);
            llamada1.agregarRespuestaDeCliente(respuestaDeCliente2);

            Llamada llamada2 = new Llamada(cliente2);
            llamada1.agregarRespuestaDeCliente(respuestaDeCliente1);
            llamada1.agregarRespuestaDeCliente(respuestaDeCliente2);

            Llamada llamada3 = new Llamada(cliente1);
            llamada1.agregarRespuestaDeCliente(respuestaDeCliente1);

            Llamada llamada4 = new Llamada(cliente2);

            //armado de estados
            Estado cancelada = new Estado("Cancelada");
            Estado finalizada = new Estado("Finalizada");
            Estado escuchada = new Estado("Escuchada");
            Estado seleccionada = new Estado("Seleccionada");
            Estado descartada = new Estado("Descartada");
            Estado enCurso = new Estado("En Curso");
            Estado iniciada = new Estado("Iniciada");

            //armado cambios de estado
            CambioEstado cambioEstado1Llamada1 = new CambioEstado(DateTime.Now.AddMinutes(-40), DateTime.Now.AddMinutes(-35), iniciada);
            CambioEstado cambioEstado2Llamada1 = new CambioEstado(DateTime.Now.AddMinutes(-30), DateTime.Now.AddMinutes(-20), enCurso);
            CambioEstado cambioEstado3Llamada1 = new CambioEstado(DateTime.Now.AddMinutes(-20), null, finalizada);
            CambioEstado cambioEstado1Llamada2 = new CambioEstado(DateTime.Now.AddMinutes(-40).AddDays(-30), DateTime.Now.AddMinutes(-35).AddDays(-30), iniciada);
            CambioEstado cambioEstado2Llamada2 = new CambioEstado(DateTime.Now.AddMinutes(-30).AddDays(-30), DateTime.Now.AddMinutes(-20).AddDays(-30), enCurso);
            CambioEstado cambioEstado3Llamada2 = new CambioEstado(DateTime.Now.AddMinutes(-20).AddDays(-30), null, finalizada);
            CambioEstado cambioEstado1Llamada3 = new CambioEstado(new DateTime(2021, 8, 15), new DateTime(2021, 8, 15), iniciada);
            CambioEstado cambioEstado2Llamada3 = new CambioEstado(new DateTime(2021, 8, 15), new DateTime(2021, 8, 15), enCurso);
            CambioEstado cambioEstado3Llamada3 = new CambioEstado(new DateTime(2021, 8, 15), null, finalizada);

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

            llamadas.Add(llamada1);
            llamadas.Add(llamada2);
            llamadas.Add(llamada3);
            return llamadas;
      
        }

        public List<Llamada> getLlamadasRespondidas() 
        {
            return llamadasRespondidas;
        }

        public List<Llamada> getLlamadas()
        {
            return llamadas;
        }

        public DataTable llamadasToDataTable(List<Llamada> llamadas) 
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Duracion");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");
            foreach (Llamada llamada in llamadas)
            {
                DataRow fila = dt.NewRow();
                fila["Duracion"] = llamada.getDuracion;
                fila["Cliente"] = llamada.getNombreCliente();
                fila["Fecha Inicio"] = llamada.getFechaInicio();
                fila["Fecha Fin"] = llamada.getFechaFin();
                dt.Rows.Add(fila);
            }
            return dt;
        }
        public DataTable encuestasToDataTable(Encuesta encuesta)
        {
            List<Encuesta> encuestas = new List<Encuesta>{ encuesta };
            return encuestasToDataTable(encuestas);

        }

        

        public DataTable encuestasToDataTable(List<Encuesta> encuestas)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Pregunta");
            dt.Columns.Add("Fecha Vigencia");
            dt.Columns.Add("Respuesta");


            foreach (Encuesta encuesta in encuestas)
            {
                DataRow fila = dt.NewRow();
                fila["Fecha Vigencia"] = encuesta.getFechaVigencia();

                foreach (Pregunta pregunta in encuesta.getPreguntas())
                {
                    foreach (RespuestaPosible respuestaPosible in pregunta.getRespuestaPosible())
                    {
                        fila["Pregunta"] = pregunta.getPregunta();
                        

                    }
                    
                }
                dt.Rows.Add(fila);
            }

            return dt;
        }
        public void getDatosLlamada() 
        {

        }

        public void seleccionarLlamada(int indice)
        {
            llamadaSeleccionada = llamadasRespondidas[indice];
        }

        public Encuesta getEncuestaLlamada()
        {
            //return llamadaSeleccionada.getEncuesta();
        }
    }
}

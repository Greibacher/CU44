using CU44.Clases_de_Entidad;
using CU44.Clases_de_Soporte;
using CU44.Controlador;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CU44
{
    public partial class PantallaConsultarEncuesta : Form
    {
        DateTime fechaInicio;
        DateTime fechaFin;
        


        ControladorConsultarEncuesta controlador = new ControladorConsultarEncuesta();
        public PantallaConsultarEncuesta()
        {
            InitializeComponent();

            dgLlamadas.Columns.Add("Duracion", "Duracion");
            dgLlamadas.Columns.Add("Cliente", "Cliente");
            dgLlamadas.Columns.Add("Fecha Inicio", "Fecha Inicio");
            dgLlamadas.Columns.Add("Fecha Fin", "Fecha Fin");
        }
        private void dgLlamadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarPeriodo_Click(object sender, EventArgs e)
        {
            //tomo las fechas de los datatimepicker
            List<Llamada> listaLlamadas= controlador.tomarDatosPeriodoLlamada(fechaInicioPer.Value, fechaFinPer.Value);
            foreach (Llamada llamada in listaLlamadas)
            {
                //no le pone la duracion a la columna, no se por que, no se si esta funcionando aunque sea, no se si toma algun objeto, como se eso AYUDA
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgLlamadas, llamada.getDuracion);
            }
        }
    }
}

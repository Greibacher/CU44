using CU44.Clases_de_Entidad;
using CU44.Clases_de_Soporte;
using CU44.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace CU44
{
    public partial class PantallaConsultarEncuesta : Form
    {
        DateTime fechaInicio;
        DateTime fechaFin;



        ControladorConsultarEncuesta controlador;

        public PantallaConsultarEncuesta()
        {
            InitializeComponent();
            controlador = new ControladorConsultarEncuesta(this);
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
            List<Llamada> listaLlamadas = controlador.tomarDatosPeriodoLlamada(fechaInicioPer.Value, fechaFinPer.Value);
            dgLlamadas.DataSource = controlador.llamadasToDataTable(listaLlamadas);
            dgLlamadas.Enabled = true;
        }

        public void pedirSeleccionLlamada()
        {
            List<Llamada> llamadas = controlador.getLlamadasRespondidas();
            DataTable dtLlamadas = controlador.llamadasToDataTable(llamadas);
            dgLlamadas.DataSource = dtLlamadas;
        }

        private void PantallaConsultarEncuesta_Load(object sender, EventArgs e)
        {
            List<Llamada> llamadas = controlador.getLlamadas();
            DataTable dtLlamadas = controlador.llamadasToDataTable(llamadas);
            dgLlamadas.DataSource = dtLlamadas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccionarLlamada(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            controlador.seleccionarLlamada(indice);
            MessageBox.Show(controlador.getLlamadaSeleccionada().getNombreCliente());
            Encuesta encuesta = controlador.getEncuestaLlamada();
            DataTable dtEncuesta = controlador.encuestasToDataTable(encuesta);
            dgEncuesta.DataSource = dtEncuesta;
        }

        private void btnImprimirCSV_Click(object sender, EventArgs e)
        {
            CSV c = new CSV();
            Encuesta encuesta = controlador.getEncuestaLlamada();
            Llamada llamada = controlador.getLlamadaSeleccionada();
            c.imprimirCSVdeEncuesta(encuesta, llamada);
        }
    }
}

using CU44.Clases_de_Soporte;
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
        public PantallaConsultarEncuesta()
        {
            InitializeComponent();
        }
        private void validarDatosFecha(object sender, KeyPressEventArgs e)
        {
            ValidadorEntradas.SoloNumeros(e);
        }


        private void btnIngresarPeriodo_Click(object sender, EventArgs e)
        {
            
        }

        private void validarFecha(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            String s = t.Text;
            if (s.Length > 10) { s = s.Substring(0, 10); }
            else if (s.Length == 10)
            {
                if (t.Name == "txtFechaInicio")
                {
                    if (FechaValida(s)) fechaInicio = convertirAFecha(s);
                    else fechaInicio = default;
                }
                if (t.Name == "txtFechaFin")
                {

                    if (FechaValida(s)) fechaFin = convertirAFecha(s);
                    else fechaFin = default;
                }
            }
            s = AlterText(s);
            t.Text = s;
            t.Select(t.Text.Length, 0);
        }

        private DateTime convertirAFecha(string s)
        {
            return DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private string AlterText(string s)
        {
            return s;
        }

        private Boolean FechaValida(String s) {
            if (s.Length != 10) return false;
            String[] datos = s.Split('/');
            if (datos.Length != 2) return false;
            try
            {
                // Validando Dias
                int x = Convert.ToInt32(datos[0]);
                if (x < 0 || x > 31) return false;
                // Validando Meses
                x = Convert.ToInt32(datos[1]);
                if (x < 0 || x > 12) return false;
                // Validar Años
                x = Convert.ToInt32(datos[2]);
                if (x < 0 || x > DateTime.Now.Year) return false;
                DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        
    }
}

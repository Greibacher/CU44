using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CU44.Clases_de_Soporte
{
    class ValidadorEntradas
    {
        public static void SoloNumeros(KeyPressEventArgs k)
        {
            if (char.IsDigit(k.KeyChar)) { k.Handled = false; }
            else if (char.IsControl(k.KeyChar)) { k.Handled = false; }
            else k.Handled = true;
        }

        public static void SoloLetras(KeyPressEventArgs k)
        {
            if (char.IsLetter(k.KeyChar)) { k.Handled = false; }
            else if (char.IsControl(k.KeyChar)) { k.Handled = false; }
            else k.Handled = true;
        }

        public static void ParaFechas(KeyPressEventArgs k)
        {
            if (char.IsDigit(k.KeyChar) || k.KeyChar == '/') { k.Handled = false; }
            else if (char.IsControl(k.KeyChar)) { k.Handled = false; }
            else k.Handled = true;
        }
    }
}

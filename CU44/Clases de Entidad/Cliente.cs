using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;

        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }

        public bool esCliente(int dniVer)
        {
            return (dni == dniVer);
        }

        public object[] getDatosCliente()
        {
            return new object[] {dni, nombreCompleto, nroCelular};
        }
    }
}

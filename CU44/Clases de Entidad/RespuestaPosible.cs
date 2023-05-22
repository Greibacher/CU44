using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU44.Clases_de_Entidad
{
    public class RespuestaPosible
    {
        private string descripcion;
        private string valor;

        public RespuestaPosible(string descr, string val)
        {
            this.descripcion = descr;
            this.valor = val;
        }
        public string getValor()
        {
            return valor;
        }
        public void setValor(string valor)
        {
            this.valor = valor;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string desc)
        {
            descripcion = desc;
        }
    }

}

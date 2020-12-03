using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados0212
{
    public delegate void Delegado(object sender, PasarValor e);
    public class PasarValor : EventArgs
    {
        private string nuevoValor;
        public PasarValor(string nuevoValor)
        {
            this.nuevoValor = nuevoValor;
        }

        public string NuevoValor
        {
            get
            {
                return nuevoValor;
            }
        }
    }
}

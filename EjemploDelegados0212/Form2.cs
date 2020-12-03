using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDelegados0212
{
    public partial class Form2 : Form
    {
        public event Delegado ValorActualizar;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text;
            PasarValor argumentos = new PasarValor(cadena);
            ValorActualizar(this, argumentos);
        }
    }
}

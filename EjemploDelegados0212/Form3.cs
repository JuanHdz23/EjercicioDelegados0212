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
    public partial class Form3 : Form
    {
        public event Delegado ValorActualizar;
        public Form3()
        {
            InitializeComponent();
        }
        public void form3_ValorActualizar(object sender, PasarValor e)
        {
            label1.Text = e.NuevoValor;
        }
    }
}

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
    public partial class Form1 : Form
    {
        private Form2 f2;
        private Form3 f3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.ValorActualizar += new Delegado(f3.form3_ValorActualizar);
            if (f2 != null)
            {
                f2.ValorActualizar += new Delegado(f3.form3_ValorActualizar);
            }
            
            f3.Show();
        }
    }
}

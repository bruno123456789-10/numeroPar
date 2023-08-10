using numeroPar.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeroPar.View
{
    public partial class TelaNumeroPar : Form
    {
        public TelaNumeroPar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);

            if (numero % 2 == 0 ) { 
                label2.Text = "Numero Par";
            }
            else
            {
                label2.Text = "Numero Impar";
            }
        }
    }
}

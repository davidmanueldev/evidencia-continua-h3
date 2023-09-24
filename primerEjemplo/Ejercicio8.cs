using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerEjemplo
{
    public partial class Ejercicio8 : Form
    {
        Form1 formPrincipal;

        public Ejercicio8(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBoxNum1.Text);
            int n2 = Convert.ToInt32(textBoxNum2.Text);

            int mcd = 0;
            int a = n1;
            int b = n2;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            mcd = a;
            int mcm = (n1 * n2) / mcd;

            labelResultado.Text = "El Mínimo Común Múltiplo es: " + mcm;
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario principal
            this.formPrincipal.Show();

            // Ocultar este formulario
            this.Hide();
        }
    }
}

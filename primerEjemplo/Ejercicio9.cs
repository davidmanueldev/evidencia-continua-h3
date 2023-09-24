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
    public partial class Ejercicio9 : Form
    {
        Form1 formPrincipal;

        public Ejercicio9(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBoxNum.Text);
            StringBuilder resultado = new StringBuilder();

            for (double a = n; a >= 1; --a)
            {
                for (double b = 1; b <= a; ++b)
                {
                    resultado.Append(" ");
                }
                for (double c = a; c <= n; ++c)
                {
                    resultado.Append(n - a + 1 + " ");
                }
                resultado.AppendLine();
            }

            labelResultado.Text = resultado.ToString();
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

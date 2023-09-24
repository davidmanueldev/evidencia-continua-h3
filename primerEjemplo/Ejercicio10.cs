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
    public partial class Ejercicio10 : Form
    {
        Form1 formPrincipal;

        public Ejercicio10(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxAltura.Text);
            StringBuilder resultado = new StringBuilder();

            if (!EsTriangular(n))
            {
                resultado.AppendLine($"El número {n} no es triangular.");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    resultado.Append(new string(' ', n - i - 1));
                    for (int j = 0; j <= i; j++)
                    {
                        resultado.Append("* ");
                    }
                    resultado.AppendLine();
                }
            }

            labelResultado.Text = resultado.ToString();
        }

        static bool EsTriangular(int num)
        {
            if (num < 0)
            {
                return false;
            }

            int suma = 0;
            int n = 1;

            while (suma <= num)
            {
                suma += n;
                if (suma == num)
                {
                    return true;
                }
                n++;
            }

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario principal
            this.formPrincipal.Show();

            // Ocultar este formulario
            this.Hide();
        }
    }
}

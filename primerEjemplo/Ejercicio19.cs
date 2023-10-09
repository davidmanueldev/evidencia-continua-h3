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
    public partial class Ejercicio19 : Form
    {
        Form1 formPrincipal;
        public Ejercicio19(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio19()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int n))
            {
                string serie = "123";
                string resultado = "";

                for (int i = 0; i < n; i++)
                {
                    resultado += serie[i % serie.Length];
                }

                lblResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para n.");
            }
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

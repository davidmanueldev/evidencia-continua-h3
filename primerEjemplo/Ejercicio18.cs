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
    public partial class Ejercicio18 : Form
    {
        private int sumatoria = 0;
        Form1 formPrincipal;

        public Ejercicio18(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio18()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numero;

            // Intenta convertir el texto en el TextBox a un número
            if (int.TryParse(txtNumero.Text, out numero))
            {
                // Verifica si el número es 9
                if (numero == 9)
                {
                    MessageBox.Show("Sumatoria terminada. El resultado es: " + sumatoria);
                    sumatoria = 0; // Reinicia la sumatoria para futuras operaciones
                }
                else
                {
                    sumatoria += numero; // Suma el número a la sumatoria total
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }

            // Limpia el TextBox para la siguiente entrada
            txtNumero.Clear();
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

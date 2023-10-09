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
    public partial class Ejercicio12 : Form
    {
        Form1 formPrincipal;

        public Ejercicio12(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        private int suma = 0;
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            // Intenta convertir el texto en el TextBox a un número
            if (int.TryParse(txtNumero.Text, out numero))
            {
                // Verifica si el número es 6
                if (numero == 6)
                {
                    MessageBox.Show("Suma terminada. El resultado es: " + suma);
                    suma = 0; // Reinicia la suma para futuras operaciones
                }
                else
                {
                    suma += numero; // Suma el número al total
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }

            // Actualiza el contenido del Label con la suma actual
            lblResultado.Text = "Suma actual: " + suma;

            // Limpia el TextBox para la siguiente entrada
            txtNumero.Clear();
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

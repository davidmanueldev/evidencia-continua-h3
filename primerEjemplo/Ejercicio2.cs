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
    public partial class Ejercicio2 : Form
    {
        Form1 formPrincipal;

        public Ejercicio2(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero) && numero >= 0)
            {
                int cantidadDeDigitos = ContarDigitos(numero);
                label1.Text = $"El número {numero} necesita {cantidadDeDigitos} dígito(s) para ser representado.";
            }
            else
            {
                label1.Text = "Por favor, ingrese un número entero positivo válido.";
            }
        }

        static int ContarDigitos(int numero)
        {
            int contador = 1; // Aca hay que comenzar con al menos un dígito

            while (numero >= 10)
            {
                numero = numero / 10;
                contador++;
            }

            return contador;
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

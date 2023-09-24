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
    public partial class Ejercicio5 : Form
    {
        Form1 formPrincipal;

        public Ejercicio5(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCantidad.Text, out int n) && n > 0)
            {
                int contador = 0;
                int numero = 2;
                StringBuilder numerosPrimos = new StringBuilder($"Los primeros {n} números primos son:\n");

                while (contador < n)
                {
                    if (EsPrimo(numero))
                    {
                        numerosPrimos.Append(numero + " ");
                        contador++;
                    }

                    numero++;
                }

                labelResultado.Text = numerosPrimos.ToString();
            }
            else
            {
                labelResultado.Text = "Por favor, ingrese un número válido mayor que cero.";
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            if (numero == 2)
            {
                return true;
            }

            if (numero % 2 == 0)
            {
                return false;
            }

            for (int divisor = 3; divisor * divisor <= numero; divisor += 2)
            {
                if (numero % divisor == 0)
                {
                    return false;
                }
            }

            return true;
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

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
    public partial class Ejercicio3 : Form
    {
        Form1 formPrincipal;
        public Ejercicio3(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero) && numero >= 1)
            {
                if (EsNumeroPerfecto(numero))
                {
                    label1.Text = $"{numero} es un número perfecto.";
                }
                else
                {
                    label1.Text = $"{numero} no es un número perfecto.";
                }
            }
            else
            {
                label1.Text = "Por favor, ingrese un número natural positivo válido.";
            }
        }

        static bool EsNumeroPerfecto(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            int sumaDivisores = 1; // Inicializamos con 1 porque todo número es divisible por sí mismo

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                    if (i != numero / i)
                    {
                        sumaDivisores += numero / i;
                    }
                }
            }

            return sumaDivisores == numero;
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

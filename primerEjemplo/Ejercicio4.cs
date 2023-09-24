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
    public partial class Ejercicio4 : Form
    {
        Form1 formPrincipal;

        public Ejercicio4(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDia.Text, out int dia) && dia >= 1 && dia <= 31)
            {
                if (int.TryParse(textBoxMes.Text, out int mes) && mes >= 1 && mes <= 12)
                {
                    if (int.TryParse(textBoxAño.Text, out int año))
                    {
                        CalcularFechaSiguiente(ref dia, ref mes, ref año);
                        labelResultado.Text = $"La fecha siguiente es: {dia}/{mes}/{año}";
                    }
                    else
                    {
                        labelResultado.Text = "Por favor, ingrese un año válido.";
                    }
                }
                else
                {
                    labelResultado.Text = "Por favor, ingrese un mes válido (1-12).";
                }
            }
            else
            {
                labelResultado.Text = "Por favor, ingrese un día válido (1-31).";
            }
        }

        static bool EsBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }

        static void CalcularFechaSiguiente(ref int dia, ref int mes, ref int año)
        {
            int[] diasPorMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (EsBisiesto(año))
            {
                diasPorMes[2] = 29; // Febrero tiene 29 días en un año bisiesto
            }

            dia++;

            if (dia > diasPorMes[mes])
            {
                dia = 1;
                mes++;

                if (mes > 12)
                {
                    mes = 1;
                    año++;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

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
    public partial class Ejercicio7 : Form
    {
        Form1 formPrincipal;

        public Ejercicio7(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);

            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }

            int mcd = num1;
            labelResultado.Text = "El Máximo Común Divisor es: " + mcd;
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

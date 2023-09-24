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
    public partial class Ejercicio6 : Form
    {
        Form1 formPrincipal;

        public Ejercicio6(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        TextBox[] coeficientesTextBoxes;
        Label[] coeficientesLabels;
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxVariable.Text);
            int grado = Convert.ToInt32(textBoxGrado.Text);

            double[] coeficientes = new double[grado + 1];
            for (int i = 0; i <= grado; i++)
            {
                coeficientes[i] = Convert.ToDouble(coeficientesTextBoxes[i].Text);
            }

            double resultado = 0;
            for (int i = 0; i <= grado; i++)
            {
                resultado += coeficientes[i] * Math.Pow(x, i);
            }

            labelResultado.Text = "El resultado es: " + resultado;
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            int grado = Convert.ToInt32(textBoxGrado.Text);
            coeficientesTextBoxes = new TextBox[grado + 1];
            coeficientesLabels = new Label[grado + 1];

            for (int i = 0; i <= grado; i++)
            {
                //coeficientesTextBoxes[i] = new TextBox();
                //coeficientesTextBoxes[i].Location = new Point(200, 30 + i * 30); // Ajusta la posición según tus necesidades
                //this.Controls.Add(coeficientesTextBoxes[i]);

                // aca meto labels para decir que coeficiente son
                
                coeficientesLabels[i] = new Label();
                coeficientesLabels[i].Text = "Coeficiente grado " + i + ":";
                coeficientesLabels[i].Location = new System.Drawing.Point(10, 30 + i * 30); // Ajusta la posición según tus necesidades
                this.Controls.Add(coeficientesLabels[i]);

                coeficientesTextBoxes[i] = new TextBox();
                coeficientesTextBoxes[i].Location = new Point(200, 30 + i * 30); // Ajusta la posición según tus necesidades
                this.Controls.Add(coeficientesTextBoxes[i]);
            }
        }

        private void textBoxGrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ejercicio6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

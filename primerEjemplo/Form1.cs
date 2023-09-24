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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio1 ejercicio1 = new Ejercicio1(this);

            // Mostrar el formulario
            ejercicio1.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void contarDigitosDeNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio2 ejercicio2 = new Ejercicio2(this);

            // Mostrar el formulario
            ejercicio2.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void numeroPerfectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio3 ejercicio3 = new Ejercicio3(this);

            // Mostrar el formulario
            ejercicio3.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void adivinarElDiaSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio4 ejercicio4 = new Ejercicio4(this);

            // Mostrar el formulario
            ejercicio4.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generarNNumerosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio5 ejercicio5 = new Ejercicio5(this);

            // Mostrar el formulario
            ejercicio5.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void evaluarPolinomioDeGradoNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio6 ejercicio6 = new Ejercicio6(this);

            // Mostrar el formulario
            ejercicio6.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void mCDDe2NúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio7 ejercicio7 = new Ejercicio7(this);

            // Mostrar el formulario
            ejercicio7.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void mCMDe2NúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio8 ejercicio8 = new Ejercicio8(this);

            // Mostrar el formulario
            ejercicio8.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void trianguloDeNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio9 ejercicio9 = new Ejercicio9(this);

            // Mostrar el formulario
            ejercicio9.Show();

            // Ocultar este formulario
            this.Hide();
        }

        private void apilarDeFormaTriangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            Ejercicio10 ejercicio10 = new Ejercicio10(this);

            // Mostrar el formulario
            ejercicio10.Show();

            // Ocultar este formulario
            this.Hide();
        }
    }
}

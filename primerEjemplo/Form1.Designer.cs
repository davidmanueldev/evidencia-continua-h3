namespace primerEjemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenciaContinuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contarDigitosDeNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroPerfectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adivinarElDiaSiguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarNNumerosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluarPolinomioDeGradoNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCDDe2NúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCMDe2NúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloDeNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apilarDeFormaTriangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenciaProcesualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.repositoriosToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidenciaContinuaToolStripMenuItem,
            this.evidenciaProcesualToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // evidenciaContinuaToolStripMenuItem
            // 
            this.evidenciaContinuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.contarDigitosDeNToolStripMenuItem,
            this.numeroPerfectoToolStripMenuItem,
            this.adivinarElDiaSiguienteToolStripMenuItem,
            this.generarNNumerosPrimosToolStripMenuItem,
            this.evaluarPolinomioDeGradoNToolStripMenuItem,
            this.mCDDe2NúmerosToolStripMenuItem,
            this.mCMDe2NúmerosToolStripMenuItem,
            this.trianguloDeNúmerosToolStripMenuItem,
            this.apilarDeFormaTriangularToolStripMenuItem});
            this.evidenciaContinuaToolStripMenuItem.Name = "evidenciaContinuaToolStripMenuItem";
            this.evidenciaContinuaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.evidenciaContinuaToolStripMenuItem.Text = "Evidencia Continua";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(308, 26);
            this.toolStripMenuItem2.Text = "1. Verificar si es primo";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // contarDigitosDeNToolStripMenuItem
            // 
            this.contarDigitosDeNToolStripMenuItem.Name = "contarDigitosDeNToolStripMenuItem";
            this.contarDigitosDeNToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.contarDigitosDeNToolStripMenuItem.Text = "2. Contar digitos de n";
            this.contarDigitosDeNToolStripMenuItem.Click += new System.EventHandler(this.contarDigitosDeNToolStripMenuItem_Click);
            // 
            // numeroPerfectoToolStripMenuItem
            // 
            this.numeroPerfectoToolStripMenuItem.Name = "numeroPerfectoToolStripMenuItem";
            this.numeroPerfectoToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.numeroPerfectoToolStripMenuItem.Text = "3. Numero Perfecto";
            this.numeroPerfectoToolStripMenuItem.Click += new System.EventHandler(this.numeroPerfectoToolStripMenuItem_Click);
            // 
            // adivinarElDiaSiguienteToolStripMenuItem
            // 
            this.adivinarElDiaSiguienteToolStripMenuItem.Name = "adivinarElDiaSiguienteToolStripMenuItem";
            this.adivinarElDiaSiguienteToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.adivinarElDiaSiguienteToolStripMenuItem.Text = "4. Adivinar el dia siguiente";
            this.adivinarElDiaSiguienteToolStripMenuItem.Click += new System.EventHandler(this.adivinarElDiaSiguienteToolStripMenuItem_Click);
            // 
            // generarNNumerosPrimosToolStripMenuItem
            // 
            this.generarNNumerosPrimosToolStripMenuItem.Name = "generarNNumerosPrimosToolStripMenuItem";
            this.generarNNumerosPrimosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.generarNNumerosPrimosToolStripMenuItem.Text = "5. Generar n numeros primos";
            this.generarNNumerosPrimosToolStripMenuItem.Click += new System.EventHandler(this.generarNNumerosPrimosToolStripMenuItem_Click);
            // 
            // evaluarPolinomioDeGradoNToolStripMenuItem
            // 
            this.evaluarPolinomioDeGradoNToolStripMenuItem.Name = "evaluarPolinomioDeGradoNToolStripMenuItem";
            this.evaluarPolinomioDeGradoNToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.evaluarPolinomioDeGradoNToolStripMenuItem.Text = "6. Evaluar polinomio de grado N";
            this.evaluarPolinomioDeGradoNToolStripMenuItem.Click += new System.EventHandler(this.evaluarPolinomioDeGradoNToolStripMenuItem_Click);
            // 
            // mCDDe2NúmerosToolStripMenuItem
            // 
            this.mCDDe2NúmerosToolStripMenuItem.Name = "mCDDe2NúmerosToolStripMenuItem";
            this.mCDDe2NúmerosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.mCDDe2NúmerosToolStripMenuItem.Text = "7. MCD de 2 números";
            this.mCDDe2NúmerosToolStripMenuItem.Click += new System.EventHandler(this.mCDDe2NúmerosToolStripMenuItem_Click);
            // 
            // mCMDe2NúmerosToolStripMenuItem
            // 
            this.mCMDe2NúmerosToolStripMenuItem.Name = "mCMDe2NúmerosToolStripMenuItem";
            this.mCMDe2NúmerosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.mCMDe2NúmerosToolStripMenuItem.Text = "8. MCM de 2 números";
            this.mCMDe2NúmerosToolStripMenuItem.Click += new System.EventHandler(this.mCMDe2NúmerosToolStripMenuItem_Click);
            // 
            // trianguloDeNúmerosToolStripMenuItem
            // 
            this.trianguloDeNúmerosToolStripMenuItem.Name = "trianguloDeNúmerosToolStripMenuItem";
            this.trianguloDeNúmerosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.trianguloDeNúmerosToolStripMenuItem.Text = "9. Triangulo de Números";
            this.trianguloDeNúmerosToolStripMenuItem.Click += new System.EventHandler(this.trianguloDeNúmerosToolStripMenuItem_Click);
            // 
            // apilarDeFormaTriangularToolStripMenuItem
            // 
            this.apilarDeFormaTriangularToolStripMenuItem.Name = "apilarDeFormaTriangularToolStripMenuItem";
            this.apilarDeFormaTriangularToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.apilarDeFormaTriangularToolStripMenuItem.Text = "10. Apilar de forma triangular";
            this.apilarDeFormaTriangularToolStripMenuItem.Click += new System.EventHandler(this.apilarDeFormaTriangularToolStripMenuItem_Click);
            // 
            // evidenciaProcesualToolStripMenuItem
            // 
            this.evidenciaProcesualToolStripMenuItem.Name = "evidenciaProcesualToolStripMenuItem";
            this.evidenciaProcesualToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.evidenciaProcesualToolStripMenuItem.Text = "Evidencia Procesual";
            // 
            // repositoriosToolStripMenuItem
            // 
            this.repositoriosToolStripMenuItem.Name = "repositoriosToolStripMenuItem";
            this.repositoriosToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.repositoriosToolStripMenuItem.Text = "Repositorios";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidenciaContinuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem evidenciaProcesualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contarDigitosDeNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroPerfectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adivinarElDiaSiguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarNNumerosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluarPolinomioDeGradoNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCDDe2NúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCMDe2NúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloDeNúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apilarDeFormaTriangularToolStripMenuItem;
    }
}


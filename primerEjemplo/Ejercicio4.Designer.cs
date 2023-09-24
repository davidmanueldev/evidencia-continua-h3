namespace primerEjemplo
{
    partial class Ejercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDia
            // 
            this.textBoxDia.Location = new System.Drawing.Point(332, 172);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(100, 22);
            this.textBoxDia.TabIndex = 0;
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(332, 213);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(100, 22);
            this.textBoxMes.TabIndex = 1;
            this.textBoxMes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(332, 261);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(100, 22);
            this.textBoxAño.TabIndex = 2;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(281, 119);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(205, 16);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Ingrese una fecha: DD/MM/AAAA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Menú Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxAño);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.textBoxDia);
            this.Name = "Ejercicio4";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
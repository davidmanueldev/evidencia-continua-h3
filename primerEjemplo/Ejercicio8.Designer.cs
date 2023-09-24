namespace primerEjemplo
{
    partial class Ejercicio8
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
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelReference1 = new System.Windows.Forms.Label();
            this.labelReference2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(336, 110);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(336, 165);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNum2.TabIndex = 1;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(300, 66);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 16);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(350, 228);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Menú Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelReference1
            // 
            this.labelReference1.AutoSize = true;
            this.labelReference1.Location = new System.Drawing.Point(306, 81);
            this.labelReference1.Name = "labelReference1";
            this.labelReference1.Size = new System.Drawing.Size(158, 16);
            this.labelReference1.TabIndex = 5;
            this.labelReference1.Text = "Ingrese el primer número:";
            // 
            // labelReference2
            // 
            this.labelReference2.AutoSize = true;
            this.labelReference2.Location = new System.Drawing.Point(300, 146);
            this.labelReference2.Name = "labelReference2";
            this.labelReference2.Size = new System.Drawing.Size(173, 16);
            this.labelReference2.TabIndex = 6;
            this.labelReference2.Text = "Ingrese el segundo número:";
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelReference2);
            this.Controls.Add(this.labelReference1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "Ejercicio8";
            this.Text = "Ejercicio8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelReference1;
        private System.Windows.Forms.Label labelReference2;
    }
}
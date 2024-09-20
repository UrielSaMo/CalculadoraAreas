namespace CalculadoraAreas
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCuadrado = new System.Windows.Forms.Button();
            this.buttonTriangulo = new System.Windows.Forms.Button();
            this.buttonCirculo = new System.Windows.Forms.Button();
            this.panelCuadrado = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResultadoCuadrado = new System.Windows.Forms.TextBox();
            this.buttonCalcularCuadrado = new System.Windows.Forms.Button();
            this.textBoxCuadradoLado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTriangulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxResultadoTriangulo = new System.Windows.Forms.TextBox();
            this.buttonCalcularTriangulo = new System.Windows.Forms.Button();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCirculo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxResultadoCirculo = new System.Windows.Forms.TextBox();
            this.buttonCalcularCirculo = new System.Windows.Forms.Button();
            this.textBoxRadio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelCuadrado.SuspendLayout();
            this.panelTriangulo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelCirculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona una figura";
            // 
            // buttonCuadrado
            // 
            this.buttonCuadrado.Location = new System.Drawing.Point(84, 3);
            this.buttonCuadrado.Name = "buttonCuadrado";
            this.buttonCuadrado.Size = new System.Drawing.Size(75, 23);
            this.buttonCuadrado.TabIndex = 1;
            this.buttonCuadrado.Text = "Cuadrado";
            this.buttonCuadrado.UseVisualStyleBackColor = true;
            this.buttonCuadrado.Click += new System.EventHandler(this.buttonCuadrado_Click);
            // 
            // buttonTriangulo
            // 
            this.buttonTriangulo.Location = new System.Drawing.Point(3, 3);
            this.buttonTriangulo.Name = "buttonTriangulo";
            this.buttonTriangulo.Size = new System.Drawing.Size(75, 23);
            this.buttonTriangulo.TabIndex = 2;
            this.buttonTriangulo.Text = "Triangulo";
            this.buttonTriangulo.UseVisualStyleBackColor = true;
            this.buttonTriangulo.Click += new System.EventHandler(this.buttonTriangulo_Click);
            // 
            // buttonCirculo
            // 
            this.buttonCirculo.Location = new System.Drawing.Point(165, 3);
            this.buttonCirculo.Name = "buttonCirculo";
            this.buttonCirculo.Size = new System.Drawing.Size(75, 23);
            this.buttonCirculo.TabIndex = 3;
            this.buttonCirculo.Text = "Circulo";
            this.buttonCirculo.UseVisualStyleBackColor = true;
            this.buttonCirculo.Click += new System.EventHandler(this.buttonCirculo_Click);
            // 
            // panelCuadrado
            // 
            this.panelCuadrado.Controls.Add(this.label7);
            this.panelCuadrado.Controls.Add(this.label5);
            this.panelCuadrado.Controls.Add(this.textBoxResultadoCuadrado);
            this.panelCuadrado.Controls.Add(this.buttonCalcularCuadrado);
            this.panelCuadrado.Controls.Add(this.textBoxCuadradoLado);
            this.panelCuadrado.Controls.Add(this.label2);
            this.panelCuadrado.Location = new System.Drawing.Point(3, 32);
            this.panelCuadrado.Name = "panelCuadrado";
            this.panelCuadrado.Size = new System.Drawing.Size(340, 152);
            this.panelCuadrado.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cuadrado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resultado";
            // 
            // textBoxResultadoCuadrado
            // 
            this.textBoxResultadoCuadrado.Location = new System.Drawing.Point(17, 103);
            this.textBoxResultadoCuadrado.Name = "textBoxResultadoCuadrado";
            this.textBoxResultadoCuadrado.ReadOnly = true;
            this.textBoxResultadoCuadrado.Size = new System.Drawing.Size(132, 20);
            this.textBoxResultadoCuadrado.TabIndex = 3;
            // 
            // buttonCalcularCuadrado
            // 
            this.buttonCalcularCuadrado.Location = new System.Drawing.Point(168, 49);
            this.buttonCalcularCuadrado.Name = "buttonCalcularCuadrado";
            this.buttonCalcularCuadrado.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularCuadrado.TabIndex = 2;
            this.buttonCalcularCuadrado.Text = "Calcular";
            this.buttonCalcularCuadrado.UseVisualStyleBackColor = true;
            this.buttonCalcularCuadrado.Click += new System.EventHandler(this.buttonCalcularCuadrado_Click);
            // 
            // textBoxCuadradoLado
            // 
            this.textBoxCuadradoLado.Location = new System.Drawing.Point(18, 52);
            this.textBoxCuadradoLado.Name = "textBoxCuadradoLado";
            this.textBoxCuadradoLado.Size = new System.Drawing.Size(132, 20);
            this.textBoxCuadradoLado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingresa el lado";
            // 
            // panelTriangulo
            // 
            this.panelTriangulo.Controls.Add(this.label8);
            this.panelTriangulo.Controls.Add(this.label6);
            this.panelTriangulo.Controls.Add(this.textBoxResultadoTriangulo);
            this.panelTriangulo.Controls.Add(this.buttonCalcularTriangulo);
            this.panelTriangulo.Controls.Add(this.textBoxAltura);
            this.panelTriangulo.Controls.Add(this.textBoxBase);
            this.panelTriangulo.Controls.Add(this.label4);
            this.panelTriangulo.Controls.Add(this.label3);
            this.panelTriangulo.Location = new System.Drawing.Point(3, 190);
            this.panelTriangulo.Name = "panelTriangulo";
            this.panelTriangulo.Size = new System.Drawing.Size(340, 147);
            this.panelTriangulo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Triangulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado";
            // 
            // textBoxResultadoTriangulo
            // 
            this.textBoxResultadoTriangulo.Location = new System.Drawing.Point(168, 104);
            this.textBoxResultadoTriangulo.Name = "textBoxResultadoTriangulo";
            this.textBoxResultadoTriangulo.ReadOnly = true;
            this.textBoxResultadoTriangulo.Size = new System.Drawing.Size(132, 20);
            this.textBoxResultadoTriangulo.TabIndex = 4;
            // 
            // buttonCalcularTriangulo
            // 
            this.buttonCalcularTriangulo.Location = new System.Drawing.Point(168, 49);
            this.buttonCalcularTriangulo.Name = "buttonCalcularTriangulo";
            this.buttonCalcularTriangulo.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularTriangulo.TabIndex = 3;
            this.buttonCalcularTriangulo.Text = "Calcular";
            this.buttonCalcularTriangulo.UseVisualStyleBackColor = true;
            this.buttonCalcularTriangulo.Click += new System.EventHandler(this.buttonCalcularTriangulo_Click);
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(19, 104);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(132, 20);
            this.textBoxAltura.TabIndex = 3;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(19, 52);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(129, 20);
            this.textBoxBase.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese la altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese la base";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonTriangulo);
            this.flowLayoutPanel1.Controls.Add(this.buttonCuadrado);
            this.flowLayoutPanel1.Controls.Add(this.buttonCirculo);
            this.flowLayoutPanel1.Controls.Add(this.panelCuadrado);
            this.flowLayoutPanel1.Controls.Add(this.panelTriangulo);
            this.flowLayoutPanel1.Controls.Add(this.panelCirculo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 511);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panelCirculo
            // 
            this.panelCirculo.Controls.Add(this.label9);
            this.panelCirculo.Controls.Add(this.label10);
            this.panelCirculo.Controls.Add(this.textBoxResultadoCirculo);
            this.panelCirculo.Controls.Add(this.buttonCalcularCirculo);
            this.panelCirculo.Controls.Add(this.textBoxRadio);
            this.panelCirculo.Controls.Add(this.label11);
            this.panelCirculo.Location = new System.Drawing.Point(3, 343);
            this.panelCirculo.Name = "panelCirculo";
            this.panelCirculo.Size = new System.Drawing.Size(340, 152);
            this.panelCirculo.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Circulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Resultado";
            // 
            // textBoxResultadoCirculo
            // 
            this.textBoxResultadoCirculo.Location = new System.Drawing.Point(17, 103);
            this.textBoxResultadoCirculo.Name = "textBoxResultadoCirculo";
            this.textBoxResultadoCirculo.ReadOnly = true;
            this.textBoxResultadoCirculo.Size = new System.Drawing.Size(132, 20);
            this.textBoxResultadoCirculo.TabIndex = 3;
            // 
            // buttonCalcularCirculo
            // 
            this.buttonCalcularCirculo.Location = new System.Drawing.Point(168, 49);
            this.buttonCalcularCirculo.Name = "buttonCalcularCirculo";
            this.buttonCalcularCirculo.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularCirculo.TabIndex = 2;
            this.buttonCalcularCirculo.Text = "Calcular";
            this.buttonCalcularCirculo.UseVisualStyleBackColor = true;
            this.buttonCalcularCirculo.Click += new System.EventHandler(this.buttonCalcularCirculo_Click);
            // 
            // textBoxRadio
            // 
            this.textBoxRadio.Location = new System.Drawing.Point(18, 52);
            this.textBoxRadio.Name = "textBoxRadio";
            this.textBoxRadio.Size = new System.Drawing.Size(132, 20);
            this.textBoxRadio.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ingresa el radio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 245);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de Areas";
            this.panelCuadrado.ResumeLayout(false);
            this.panelCuadrado.PerformLayout();
            this.panelTriangulo.ResumeLayout(false);
            this.panelTriangulo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelCirculo.ResumeLayout(false);
            this.panelCirculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCuadrado;
        private System.Windows.Forms.Button buttonTriangulo;
        private System.Windows.Forms.Button buttonCirculo;
        private System.Windows.Forms.Panel panelCuadrado;
        private System.Windows.Forms.Button buttonCalcularCuadrado;
        private System.Windows.Forms.TextBox textBoxCuadradoLado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTriangulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxResultadoCuadrado;
        private System.Windows.Forms.TextBox textBoxResultadoTriangulo;
        private System.Windows.Forms.Button buttonCalcularTriangulo;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelCirculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxResultadoCirculo;
        private System.Windows.Forms.Button buttonCalcularCirculo;
        private System.Windows.Forms.TextBox textBoxRadio;
        private System.Windows.Forms.Label label11;
    }
}


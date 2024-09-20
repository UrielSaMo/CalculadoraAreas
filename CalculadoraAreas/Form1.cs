using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CalculadoraAreas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Ocultar todos los paneles al inicio
            panelTriangulo.Visible = false;
            panelCuadrado.Visible = false;
            panelCirculo.Visible = false;
        }

        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelCuadrado);
        }

        private void buttonTriangulo_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelTriangulo);
        }
        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelCirculo);
        }

        private void MostrarPanel(Panel panelSeleccionado)
        {
            // Oculta todos los paneles
            panelTriangulo.Visible = false;
            panelCuadrado.Visible = false;
            panelCirculo.Visible = false;

            // Muestra el panel seleccionado
            panelSeleccionado.Visible = true;
        }



        private void buttonCalcularCuadrado_Click(object sender, EventArgs e)
        {
            double lado, res;
            string texto = textBoxCuadradoLado.Text;
            bool NumeroValido = double.TryParse(textBoxCuadradoLado.Text, out lado);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    res = lado * lado * Math.PI;
                    textBoxResultadoCuadrado.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }

        }

        private void buttonCalcularTriangulo_Click(object sender, EventArgs e)
        {
            double baseT, altura, res;

            string texto = textBoxBase.Text;
            string texto2 = textBoxAltura.Text;

            bool NumeroValido = double.TryParse(textBoxBase.Text, out baseT);
            bool NumeroValido2 = double.TryParse(textBoxAltura.Text, out altura);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    baseT = double.Parse(textBoxBase.Text);
                    altura = double.Parse(textBoxAltura.Text);
                    res = (baseT * altura) / 2;
                    textBoxResultadoTriangulo.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
            
        }

        private void buttonCalcularCirculo_Click(object sender, EventArgs e)
        {
            double res, radio;

            string texto = textBoxRadio.Text;
            bool NumeroValido = double.TryParse(textBoxRadio.Text, out radio);
            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    radio = double.Parse(textBoxRadio.Text);
                    res = Math.Sqrt(radio) * Math.PI;
                    textBoxResultadoCirculo.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
            
           
           
        }
    }
}

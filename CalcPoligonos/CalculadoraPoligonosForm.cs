using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace CalcPoligonos
{
    public partial class CalculadoraPoligonosForm : Form
    {
        ICalculable figuraSeleccionada;
        public CalculadoraPoligonosForm()
        {
            InitializeComponent();
        }

        private void principalTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(principalTabControl.SelectedIndex == 0)
            {
                figuraSeleccionada = new Triangulo();
            }

            if (principalTabControl.SelectedIndex == 1)
            {
                figuraSeleccionada = new Rectangulo();
            }

            if (principalTabControl.SelectedIndex == 2)
            {
                figuraSeleccionada = new Circulo();
            }

            if (principalTabControl.SelectedIndex == 3)
            {
                figuraSeleccionada = new Rectangulo();
            }

            if (principalTabControl.SelectedIndex == 4)
            {
                figuraSeleccionada = new Pentagono();
            }
        }

        private void CuadradoLadoTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo) figuraSeleccionada;
            rectangulo.Lado = Convert.ToDouble(CuadradoLadoTextBox.Text);
            rectangulo.Altura = Convert.ToDouble(CuadradoLadoTextBox.Text);

        }

        private void trianguloBaseTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Base  = Convert.ToDouble(trianguloBaseTextBox.Text);
        }

        private void trianguloAlturaTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Altura = Convert.ToDouble(trianguloAlturaTextBox.Text);
        }

        private void trianguloLado1TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Lado1 = Convert.ToDouble(trianguloLado1TextBox.Text);
        }

        private void trianguloLado2TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Lado2 = Convert.ToDouble(trianguloLado2TextBox.Text);
        }

        private void trianguloLado3TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Lado3 = Convert.ToDouble(trianguloLado3TextBox.Text);
        }

        private void circuloRadioTextBox_Leave(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)figuraSeleccionada;
            circulo.Radio = Convert.ToDouble(circuloRadioTextBox.Text);
        }

        private void circuloPerimetroTextBox_Leave(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)figuraSeleccionada;
            circulo.Perimetro = Convert.ToDouble(circuloPerimetroTextBox.Text);
        }

        private void rectanguloBaseTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)figuraSeleccionada;
            rectangulo.Lado = Convert.ToDouble(rectanguloBaseTextBox.Text);
        }

        private void rectanguloAlturaTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)figuraSeleccionada;
            rectangulo.Lado = Convert.ToDouble(rectanguloAlturaTextBox.Text);
        }

        private void pentagonoLadoTextBox_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)figuraSeleccionada;
            pentagono.Lado = Convert.ToDouble(pentagonoLadoTextBox.Text);
        }

        private void pentagonoApotemaTextBox_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)figuraSeleccionada;
            pentagono.Apotema = Convert.ToDouble(pentagonoApotemaTextBox.Text);
        }

        private void CalcularPerimetroButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El perimetro es:" + figuraSeleccionada.CalcularPerimetro());
        }

        private void CalcularAreaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El area es:" + figuraSeleccionada.CalcularArea());
        }
    }
}

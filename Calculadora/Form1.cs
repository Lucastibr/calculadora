using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbResultado.Text = Somar (numero1, numero2).ToString();
            
        }

        int Somar (int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbResultado.Text = Multiplicar(numero1, numero2).ToString();

        }

        int Multiplicar (int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbResultado.Text = Subtrair(numero1, numero2).ToString();
        }

        int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbnumero1.Text);
            int numero2 = Convert.ToInt32(txbnumero2.Text);
            txbResultado.Text = Dividir(numero1, numero2).ToString();
        }

        int Dividir (int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}

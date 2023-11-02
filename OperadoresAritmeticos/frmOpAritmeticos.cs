using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSharp.OperadoresAritmeticos
{
    public partial class frmOpAritmeticos : Form
    {
        public frmOpAritmeticos()
        {
            InitializeComponent();
        }
        double numero1;
        double numero2;
        double resultado;

        private void frmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void Suma()
        {
            try
            {
                numero1 = Convert.ToDouble(txtNum1.Text);
                numero2 = Convert.ToDouble(txtNum2.Text);
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Resta();
        }
        
        private void Resta()
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }
        private void Multiplicar()
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Dividir();
        }
        private void Dividir()
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            resultado = numero1 / numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

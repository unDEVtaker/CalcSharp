﻿using System;
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
        int numero1;
        int numero2;
        int resultado;

        private void frmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void Suma()
        {
            numero1 = Convert.ToInt32(txtNum1.Text);
            numero2 = Convert.ToInt32(txtNum2.Text);
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos
{
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }



        private void btnSumarNumero_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse( txtNumero1.Text );
            int num2 = int.Parse( txtNumero2.Text );
            int resultado = num1 + num2;
            label3.Text = "Numero Resultado : " + resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form07SumarNumerosString : Form
    {
        public Form07SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnCadena_Click(object sender, EventArgs e)
        {
            string numeros = txtCadena.Text;
            int longitud = numeros.Length;
            int suma = 0;
            for (int i = 0; i < longitud; i++)
            {
                char caracter = numeros[i];
                if (char.IsNumber(caracter))
                {
                    int numero = int.Parse(caracter.ToString());
                    suma += numero;
                }
            }
            lblSuma.Text = "La suma es: " + suma;

        }
    }
}

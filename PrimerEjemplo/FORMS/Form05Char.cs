using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnASCI_Click(object sender, EventArgs e)
        {
            this.btnASCI.BackColor = Color.Aqua;
            for (int i = 0; i <= 255; i++)
            {
                char caracter = (char)i;
                if (char.IsLetter(caracter))
                {
                    this.txtMultiLetras.Text = this.txtMultiLetras.Text + caracter;
                }
                else if (char.IsNumber(caracter))
                {
                    this.txtMultiNumeros.Text += caracter;
                }
                else if (char.IsSymbol(caracter))
                {
                    this.txtMultiSimbolos.Text += caracter;
                }
                else if (char.IsPunctuation(caracter))
                {
                    this.txtMultiPuntuacion.Text += caracter;
                }
             
            }
        }
    }
}

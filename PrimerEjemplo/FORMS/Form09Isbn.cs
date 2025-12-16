using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;
using System.Web;
namespace NetCoreFundametos.FORMS
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnIsbn_Click(object sender, EventArgs e)
        {
            string cadenaIsbn = this.txtIsbn.Text;
            int suma = 0;

            for(int i = 0; i < cadenaIsbn.Length; i++)
            {
                char caracter = cadenaIsbn[i];
                if (char.IsDigit(caracter))
                {
                    int digito = int.Parse(caracter.ToString());
                    suma += digito * (i + 1);
                }
            }
            if (suma % 11 == 0)
            {
                this.lblResultado.Text = "El ISBN es correcto";
            }
            else
            {
                this.lblResultado.Text = "El ISBN no es correcto";
            }
        }
    }
} 

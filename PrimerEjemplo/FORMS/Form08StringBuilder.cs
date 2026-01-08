using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundametos.FORMS
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            string cadena = this.txtTrabajar.Text;
            int longitud = cadena.Length;

            //COMENZAMOS EL PROCESO
            stopwatch.Start();
            for (int i = 0; i < longitud; i++)
            {
                char caracter = cadena[longitud-1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena.Insert(i, caracter.ToString());
            }
            stopwatch.Stop();

            this.lblTiempo.Text = "Tiempo: " + stopwatch.ElapsedMilliseconds + "ms cadena invertida : " + cadena;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
           
            Stopwatch stopwatch = new Stopwatch();
            string texto = this.txtTrabajar.Text;

            StringBuilder sb = new StringBuilder(texto.Length);

            stopwatch.Start();

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                sb.Append(texto[i]);
            }

            stopwatch.Stop();

            this.lblTiempo.Text = "Tiempo: " + stopwatch.ElapsedMilliseconds +
                                  " ms | Cadena invertida: " + sb.ToString();
        }

    }
}


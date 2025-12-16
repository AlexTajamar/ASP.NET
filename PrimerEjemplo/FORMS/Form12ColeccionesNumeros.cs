using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form12ColeccionesNumeros : Form
    {
        public Form12ColeccionesNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();   
            for (int i = 0; i < 11; i++)
            {
                int random = new Random().Next(1, 20);
                this.lstNumeros.Items.Add(random);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int pares = 0;
            int impares = 0;
            int sumaTotal=0;
            foreach (int numero in this.lstNumeros.Items)
            {
                if (numero % 2 == 0) {
                pares+=numero;
                sumaTotal+=numero;
                }
                else { 
                impares+=numero;
                sumaTotal+=numero;  
                }

            }
            this.textBox1.Text = sumaTotal.ToString();
            this.textBox2.Text = pares.ToString();
            this.textBox3.Text = impares.ToString();
        }
    }
}

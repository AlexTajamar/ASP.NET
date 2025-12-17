using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDobleRef_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox1.Text);
            this.GetDobleValor(num);
            this.label2.Text = "El doble es: " + num;
        }

        private void btnObjetoRef_Click(object sender, EventArgs e)
        {

            this.CambiarColor(this.btnObjetoRef);

        }

        void GetDobleValor(int numero)
        {
            //NO RELACIONA LAS VARIABLES NO CABIA EL DATO
            numero = numero * 2;
        }

        void CambiarColor(Button n)
        {
            n.BackColor = Color.Aqua;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox1.Text);
            this.GetDobleReferencia(ref num);
            this.label2.Text = "El doble es: " + num;

        }
        void GetDobleReferencia(ref int numero)
        {
            //AHORA SI CAMBIA EL DATO
            numero = numero * 2;
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = $"X: {e.X} , Y: {e.Y} ";
        }

        private void txtNumerosCordenadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //INDICA SI NOS HACEMOS CARGO DEL EVENTO O NO
            e.Handled = true;
            char teclaBorrar = (char)8;

            char letra = e.KeyChar;
            if (char.IsDigit(letra) && e.KeyChar!=teclaBorrar)
            {
                e.Handled = false;
            }

        }

        private void txtLetraasCordenadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            char teclaBorrar = (char)8;

            char letra = e.KeyChar;
            if (char.IsLetter(letra) && e.KeyChar != teclaBorrar)
            {
                e.Handled = false;
            }

        }
    }
}

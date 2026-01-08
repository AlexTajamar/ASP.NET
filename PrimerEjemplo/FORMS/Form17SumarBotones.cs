using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones = new List<Button>();
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            //RECORREMOS TODOS LOS BOTONES DEL PANEL 
            //COMO SOLO HE DIBUJADO BOTONES HACEMOS LA ABSTRACCION A BOTON
            foreach (Button b in this.pnlBotones.Controls) {
                this.botones.Add(b);
                b.Click += SumarNumeros;
            }
         
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            int total = int.Parse(this.txtSuma.Text);
            total += numero;
            this.txtSuma.Text = total.ToString();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Button b in this.botones)
            {
             int aleatorio = rnd.Next(1, 101);
                b.Text = aleatorio.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form18CheckRadios : Form
    {
        private readonly List<CheckBox> checks;

        public Form18CheckRadios()
        {
            InitializeComponent();
            this.checks = new List<CheckBox>();
            //RECORREMOS TODOS LOS BOTONES DEL PANEL 
            //COMO SOLO HE DIBUJADO BOTONES HACEMOS LA ABSTRACCION A BOTON
            foreach (CheckBox b in this.pnlBotones.Controls)
            {
                this.checks.Add(b);
                b.Click += B_Click;
            }
        }

        private void B_Click(object? sender, EventArgs e)
        {
            CheckBox c = (  CheckBox)sender;
            int numero = int.Parse(c.Text);
            int total = int.Parse(this.txtSuma.Text);
            total += numero;
            this.txtSuma.Text = total.ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (CheckBox b in this.checks)
            {
                int aleatorio = rnd.Next(1, 101);
                b.Text = aleatorio.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string email = txtEmail.Text;

            if (!email.Contains("@"))
            {
                label1.Text = "Email NO VALIDO POR NO TENER @";
            }
            else if (email.Substring(email.LastIndexOf('.')+1).Length <2 && email.Substring(email.LastIndexOf('.') + 1).Length >3)
            {
                label1.Text = "Email NO VALIDO";
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                label1.Text = "Email NO VALIDO POR EMPEZAR O TERMINAR CON @";
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                label1.Text = "Email NO VALIDO POR MAS DE UN ARROBA";
            }
            else if (email.IndexOf(".", email.IndexOf("@") + 1) == -1)
            {
                label1.Text = "Email NO VALIDO POSICION DEL PUNTO";
            }
            else
            {
                label1.Text = "Email VALIDO";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Add(this.txtElement.Text);
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            //string elemento = this.lstElementos.SelectedItem.ToString();
            //this.lstElementos.Items.Remove(elemento);
            int index = this.lstElementos.SelectedIndex;
            if (index != -1)
            {
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIdex.Text = "Índice: " + this.lstElementos.SelectedIndex;
                this.lblItems.Text = "Item: " + this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}

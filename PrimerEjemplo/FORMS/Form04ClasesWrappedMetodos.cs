using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form04ClasesWrappedMetodos : Form
    {
        public Form04ClasesWrappedMetodos()
        {
            InitializeComponent();
            this.txtDataTime.Text = DateTime.Now.ToString();
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtDataTime.Text);
            if (chkFormato.Checked)
            {
                this.txtDataTime.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtDataTime.Text = fecha.ToShortDateString();

            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtDataTime.Text);
            if (this.radioButton1.Checked) { 
            fecha = fecha.AddDays(incremento);
            }
            if (this.radioButton2.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            }
            if (this.radioButton3.Checked)
            {
                fecha = fecha.AddYears(incremento);
            }

            fecha =  fecha.AddDays(incremento);
            this.txtFechaFinal.Text= fecha.ToString();
        }
    }
}

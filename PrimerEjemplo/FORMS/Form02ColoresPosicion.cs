using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }



        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse( txtPosX.Text );
            int y = int.Parse( txtPosY.Text );
            this.btnPosicion.Location = new Point(x, y);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int r = int.Parse(txtR.Text);
            int g = int.Parse( txtG.Text );
            int b = int.Parse( txtB.Text );
            this.BackColor = Color.FromArgb(r, g, b);
                                                        

        }
    }
}

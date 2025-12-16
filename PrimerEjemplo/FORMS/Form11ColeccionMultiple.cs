using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Add(this.txtElement.Text);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblIdex.Text = indices.Trim(',');
            this.lblItems.Text = items.Trim(',');
        }

        private void btnElimSeleccionados_Click(object sender, EventArgs e)
        {
            //string data = "";
            //foreach (string item in this.lstElementos.SelectedItems)
            //{
            //    data += item + ",";
            //}
            //this.lblIdex.Text = data.Trim(',');

            //HAY QUE ELIMINAR DE FORMA INVERSA
            //for (int i =0; i < this.lstElementos.SelectedIndices.Count; i++)
            //{
            //    int index = lstElementos.SelectedIndices[i];
            //    //INDICE DEL QUE QEREMOS BORRAR 

            //    this.lstElementos.Items.RemoveAt(index);
            //}
            int numElemntos = this.lstElementos.SelectedItems.Count - 1;
            for(int i=numElemntos;i >= 0;i--)
            {
                int index = lstElementos.SelectedIndices[i];
                    //INDICE DEL QUE QEREMOS BORRAR 

                this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}

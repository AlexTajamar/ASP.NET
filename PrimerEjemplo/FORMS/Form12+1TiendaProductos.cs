using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form12_1TiendaProductos : Form
    {
        public Form12_1TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Add(this.txtCosas.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElemntos = this.lstTienda.SelectedItems.Count - 1;
            for (int i = numElemntos; i >= 0; i--)
            {
                int index = lstTienda.SelectedIndices[i];
                //INDICE DEL QUE QEREMOS BORRAR 

                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstTienda.SelectedItems.Count; i++)
            {
                string item = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(item);
            }

        }

        private void btnTodosIzq_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.lstTienda.Items.Count; i++)
            {
                string item = this.lstTienda.Items[i].ToString();
                this.lstAlmacen.Items.Add(item);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex != -1)
            {
                string itemSeleccionado = this.lstAlmacen.SelectedItem.ToString();
                //La cadena
                int indexSeleccionado = this.lstAlmacen.SelectedIndex;
                //Indice del seleccionado 

                this.lstAlmacen.Items.RemoveAt(indexSeleccionado);
                this.lstAlmacen.Items.Insert(0, itemSeleccionado);
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex != -1)
            {
                string itemSeleccionado = this.lstAlmacen.SelectedItem.ToString();
                //La cadena
                int indexSeleccionado = this.lstAlmacen.SelectedIndex;
                //Indice del seleccionado 

                this.lstAlmacen.Items.RemoveAt(indexSeleccionado);
                this.lstAlmacen.Items.Insert(lstAlmacen.Items.Count, itemSeleccionado);
            }
        }
    }
}

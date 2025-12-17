using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //CREAMOS UNA COLECCION GENERICA TIPO BUTTON
            List<Button> listaBotones = new List<Button>();
            //DETECTA AUTOMATICAMENTE EL TIPO DE DATO
            listaBotones.Add(this.button1);
            listaBotones.Add(this.button2);
            listaBotones.Add(this.button3);
            //listaBotones.Add(this.textBox1);
            //CONTROLA SI NO ES ES DEL TIPO






            //VAMOS A CREAR UNA COLECCION NO TIPADA
            ArrayList lista = new ArrayList();
            lista.Add(this.button1);
            lista.Add(this.button2);
            lista.Add(this.button3);
            //SI DESEAMOS RECORRERLA Y MODIFCARLA TENEMOS QUE HACER UN CASTING
            //lista[0].BackColor = Color.Aqua; NO FUNCIONA 
            ((Button)lista[0]).BackColor = Color.Aqua;
            foreach(Button boton in lista)
            {
               boton.BackColor = Color.LightGray;
            }
            //Agregamos otro control que no es boton
            //HAY QUE REALIZAR ABSTRACCION (Control) PARA EVITAR ERRORES EN TIEMPO DE EJECUCION
            lista.Add(this.textBox1); //AGREGAMOS UN TEXTBOX PARA COMPROBARLO
            foreach (Control boton in lista)
            {
                boton.BackColor = Color.Yellow;
                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }
            this.button1.Click += MetodoDeLegado;  
        }
       
        void MetodoDeLegado(object sender ,EventArgs e)
        {
          
        }

        private void Form15ArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}

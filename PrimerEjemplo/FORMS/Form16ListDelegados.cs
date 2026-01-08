using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundametos.FORMS
{
    public partial class Form16ListDelegados : Form
    {
        int contador;

        public Form16ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            //ALMACENAR TODOS LOS BOTONOES EN UNA COLECCION    ;
            List<Button> listaBotones = new List<Button>();
            listaBotones.Add(this.button1);
            listaBotones.Add(this.button2);
            listaBotones.Add(this.button3);
            listaBotones.Add(this.button4);
            listaBotones.Add(this.button5);
            listaBotones.Add(this.button6);
            //VAMOS A CREAR UN METODO PARA QUE TODOS LOS BOTONES LEAN AL SER PULSADOS
            foreach (Button boton in listaBotones)
            {
                boton.Click += PulsarBoton;
            }
            foreach (Control control in this.Controls)
            {
               if(control is Button)
                {
                    listaBotones.Add((Button)control);
                }
            }
        }
        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador++;
            this.textBox1.Text = "Has pulsado " + this.contador + " veces";
            //QUEREMOS SABER QUE BOTON SE HA PULSADO
            //SE HACE mediante EL PARAMETRO SENDER
            Button botonPulsado = (Button)sender;
            botonPulsado.BackColor = Color.Aqua; 
        }


    }
}

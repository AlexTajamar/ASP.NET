using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundametos.FORMS
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona ppersona = new Persona();
            ppersona.Nombre = "Juan";
            ppersona.Apellidos = "Pérez";
            ppersona.Edad = 30;
            ppersona.Genero = TipoGenero.Masculino;
            ppersona.Nacionalidad= Paises.España;
            this.lstClases.Items.Add(ppersona.Nombre + " " + ppersona.Apellidos + ", " + ppersona.Edad + " años");
            this.lstClases.Items.Add(ppersona.GetNombreCompleto(true));



            Direccion direccion = new Direccion("Alcala","Madrid", "28001");  
            this.lstClases.Items.Add("Vive en " + direccion.Calle + ", " + direccion.Ciudad);

        }
    }
}

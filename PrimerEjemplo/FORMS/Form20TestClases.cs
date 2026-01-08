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
            ppersona.Nacionalidad = Paises.España;
            this.lstClases.Items.Add(ppersona.Nombre + " " + ppersona.Apellidos + ", " + ppersona.Edad + " años");
            this.lstClases.Items.Add(ppersona.GetNombreCompleto(true));



            ppersona[0] = "Vamos 1";
            ppersona[1] = "Vamos 2";



            Direccion direccion = new Direccion("Alcala", "Madrid", "28001");
            this.lstClases.Items.Add("Vive en " + direccion.Calle + ", " + direccion.Ciudad);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            //Empleado empleado2 = new Empleado("Paco","Porras");
            empleado.Nombre = "Ana";
            empleado.Apellidos = "García";
            this.lstClases.Items.Add("EMPLEADO : " + empleado.GetNombreCompleto());
            this.lstClases.Items.Add("Salario : " + empleado.GetSalario() + "€");
            this.lstClases.Items.Add("Días Vacaciones : " + empleado.GetDiasVacaciones());


            Director director = new Director();
            director.Nombre = "Josema";
            director.Apellidos = "La Ñema";
            this.lstClases.Items.Add("DIRECTOR : " + director.GetNombreCompleto());
            this.lstClases.Items.Add("Salario  : " + director.GetSalario() + "€");
            this.lstClases.Items.Add("Días Vacaciones : " + director.GetDiasVacaciones());
        }
    }
}

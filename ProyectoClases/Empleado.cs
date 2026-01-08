using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int Salario { get; set; }
        public Empleado()
        {
            Debug.WriteLine("cONSTRUCTOR EMPLEADO vacio");
            this.Salario = 1600;
        }
        public virtual int GetDiasVacaciones()
        {
            return 22;
        }

        public int GetSalario()
        {
            return this.Salario;
        }

        public Empleado(string NOMBRE, string APELLIDO)
        {
            this.Nombre = NOMBRE;
            this.Apellidos = APELLIDO;
            Debug.WriteLine("Constructor CON PARAMETROS Empleado ");
        }
    }
}

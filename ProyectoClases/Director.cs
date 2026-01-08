using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("CONSTRUCTOR DIRECTOR vacio");
            this.Salario += 200;
            
        }
        public int GetDiasVacaciones()
        {
            return 30;
        }
    }
}

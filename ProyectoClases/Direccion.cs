using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Sin parametros");
        }
        public Direccion(string calle, string ciudad)
        {

            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Con parametros sin codigoPostal");


        }
        public Direccion(string calle, string ciudad, string codigoPostal) { 

            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Con parametros");


        }
    }
}

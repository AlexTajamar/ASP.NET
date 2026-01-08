using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoClases
{
    public interface IFacturas
    {


         int PrecioBase { get; set; }
         int precioFinal { get; set; }
        int precioTotal { get; set; }
        void CalcularIVA();
        void OdioHacienda(int mucho);
    }
}

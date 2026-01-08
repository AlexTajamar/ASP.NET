using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public class Facturas : IFacturas
    {
        public int PrecioBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int precioFinal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int precioTotal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalcularIVA()
        {
            throw new NotImplementedException();
        }

        public void OdioHacienda(int mucho)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    //LSD ENUMERACIONES
    public enum TipoGenero { Masculino,Femenino}
    public enum Paises {España,Francia,Alemania }
    
        
    
    public class Persona
    {

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //CAMPO DE PROPIEDAD PRIVADO    
        private int _Edad;

        public int Edad { get { return this._Edad; } set { 
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            } 
        } 
    }
}

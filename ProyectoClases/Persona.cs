using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    //LSD ENUMERACIONES
    public enum TipoGenero { Masculino,Femenino}
    public enum Paises {España,Francia,Alemania }
    
        
    
    public class Persona
    {
        public Persona() { 
        Debug.WriteLine("Constructor VACIO Persona ");
        }

        public Persona(string NOMBRE , string APELLIDO) { 
            this.Nombre = NOMBRE;
            this.Apellidos = APELLIDO;
            Debug.WriteLine("Constructor CON PARAMETROS Persona ");
        }
        #region PROPIEDADES
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return _DescripcionThis; }
            set {Random random = new Random();
                int dato = random.Next(1, 20);
                _DescripcionThis = "Descripcion : " + dato; }
        }
        public Direccion Domicilio { get; set; }
        public Direccion LugarVacaciones { get; set; }

        public TipoGenero Genero { get; set; }
        public TipoGenero _Genero { get; set {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino) { 
                throw new Exception("El género no es válido");
                }
                else
                {
                    this._Genero = value;
                }
            } }
        public Paises _Nacionalidad { get; set; }
        public Paises Nacionalidad { get; set; }

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
        #endregion
        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + ", " + this.Nombre;
        }
        public string GetNombreCompleto(int numero1) {
            return this.GetNombreCompleto().ToUpper(); 
                
        }
        public string GetNombreCompleto(int numero1 , int numero2)
        {
            return this.GetNombreCompleto().ToLower();


        }


        #endregion

    }
}

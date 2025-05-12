using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cliente : Usuario
    {
        //uml hecho
        private int _ci;
        private string _nombre;
        private string _nacionalidad;


        public int Ci { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public Cliente(string mail, string user, string password,int ci, string nombre, string nacionalidad) : base(mail, user, password)
        {
            this._ci = ci;
            this._nombre = nombre;
            this._nacionalidad = nacionalidad;
        }
        public Cliente() { }

        private string getNombre()
        {
            return this._nombre;
        }

        public string GetNombre()
        {
            return getNombre();
        }

        private string getNacionalidad()
        {
            return this._nacionalidad;
        }

        public string GetNacionalidad()
        {
            return getNacionalidad();
        }
        private int getCi()
        {
            return this._ci;
        }
        public int GetCi()
        {
            return getCi();
        }
        public virtual string ToString()
        {
            return $"Nombre:{this._nombre}\nEmail:{this.Mail}\nNacionalidad:{this._nacionalidad}";
        }

    }
    
}

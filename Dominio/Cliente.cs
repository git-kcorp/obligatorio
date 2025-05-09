using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cliente : Usuario
    {
        private int _ci;
        private string _nombre;
        private string _nacionalidad;
        private TipoCliente _tipoCliente;
        private int _puntos=0;

        public int Ci { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public int Puntos { get; set; }


        public Cliente(string mail, string user, string password,int ci, string nombre, string nacionalidad, TipoCliente tipoCliente) : base(mail, user, password)
        {
            this._ci = ci;
            this._nombre = nombre;
            this._nacionalidad = nacionalidad;
            this._tipoCliente = tipoCliente;
        }
        public Cliente() { }

        private TipoCliente getTipoCliente()
        {
            return this._tipoCliente;
        }

        public TipoCliente GetTipoCliente()
        {
            return getTipoCliente();
        }

        private string getNombre()
        {
            return this._nombre;
        }

        public string GetNombre()
        {
            return getNombre();
        }

        public override string ToString()
        {
            return $"Nombre:{this._nombre}\nEmail:{this.Mail}\nNacionalidad:{this._nacionalidad}\nPuntos:{this._puntos}\nTipo de cliente: {this._tipoCliente}";
        }

    }
    
}

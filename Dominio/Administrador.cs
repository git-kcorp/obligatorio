using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Administrador : Usuario
    {
        //hecho uml
        private string _apodo;

        public string Apodo {
            get { return _apodo; }
            set { _apodo = value; }
        }

        public Administrador(string mail,string user,string password,string apodo) : base(mail,user,password)
        {
            this._apodo = apodo;
        }
        public Administrador() { }

        private string getApodo()
        {
            return this._apodo;
        }

        public string GetApodo()
        {
            return getApodo();
        }

        public override string ToString()
        {
            return $"Usuario:{this.User}\nEmail:{this.Mail}\nApodo:{this._apodo}\n";
        }
    }
}

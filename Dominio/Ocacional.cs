using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Ocacional : Cliente
    {
        private bool _elegible = false;

        public bool Elegible { get; set; }


        public Ocacional(string mail, string user, string password, int ci, string nombre, string nacionalidad, bool elegible) : base(mail, user, password, ci, nombre, nacionalidad)
        {
            this._elegible = elegible;
        }
        public Ocacional() { }

        public override string ToString()
        {
            string baseInfo = base.ToString();
            string response = "";
            if (_elegible)
            {
                response = "Si";
            }
            else
            {
                response = "No";
            }
            return $"{baseInfo}\nTipo CLiente: Ocacional\nEs elegible? {response}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Ocacional : Cliente
    {
        //hecho UML
        private bool _elegible = false;

        public bool Elegible { get; set; }
        Random rnd = new Random();




        public Ocacional(string mail, string user, string password, int ci, string nombre, string nacionalidad) : base(mail, user, password, ci, nombre, nacionalidad)
        {
            bool random = rnd.Next(0, 2) == 1;
            this._elegible = random;
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

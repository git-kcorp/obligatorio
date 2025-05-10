using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Premium : Cliente
    {
        private static int _puntos = 0;
        public int Puntos { get; set; }

        public Premium(string mail, string user, string password, int ci, string nombre, string nacionalidad) : base( mail,  user,  password,  ci,  nombre,  nacionalidad)
        {

        }
        public Premium() { }

        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}\nTipo Cliente:Premium\nPuntos:{_puntos}";
        }

    }
}

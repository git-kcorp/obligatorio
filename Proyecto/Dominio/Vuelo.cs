using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Vuelo
    {
        //UML CREADO
        private static int _nextId=1;

        private int _id;
        private string _numeroVuelo;
        private Ruta _ruta;
        private Avion _avion;
        private List<FrecuenciaVuelo> _frecuencia;

        public string NumeroVuelo { get { return _numeroVuelo; }set { this._numeroVuelo = value; } }
        public Ruta Ruta { get { return this._ruta; }set {this._ruta = value; } }
        public Avion Avion { get { return this._avion; } set { this._avion = value; } }
        public List<FrecuenciaVuelo> Frecuencia { get { return this._frecuencia; } set { this._frecuencia = value; } }

        public Vuelo(string numeroVuelo, Ruta ruta, Avion avion, List<FrecuenciaVuelo> frecuencia)
        {
            this._id = _nextId++;
            this._numeroVuelo=numeroVuelo;
            this._ruta=ruta;
            this._avion=avion;
            this._frecuencia=frecuencia;
        }
        public Vuelo() { }

        public override string ToString()
        {
            string frecuencia = "";
            foreach (FrecuenciaVuelo frecuence in this._frecuencia)
            {
                frecuencia += frecuence;

                if (frecuence != this._frecuencia[this._frecuencia.Count-1])
                {
                    frecuencia += "-";
                }
            }

            return $"Numero de vuelo:{this._numeroVuelo}\nModelo:{this._avion.GetModelo()}\nRuta:{this._ruta.GetAeropuertoE().GetCodigo()}-{this._ruta.GetAeropuertoS().GetCodigo()}\nFrecuencia:{frecuencia}\n";
        }

        private int getId()
        {
            return this._id;
        }
        public int GetId()
        {
            return getId();
        }

        private Avion getAvion()
        {
            return this._avion;
        }
        public Avion GetAvion()
        {
            return getAvion();
        }
        private Ruta getRuta()
        {
            return this._ruta;
        }
        public Ruta GetRuta()
        {
            return getRuta();
        }
        private string getNroVuelo()
        {
            return this._numeroVuelo;
        }
        public string GetNroVuelo()
        {
            return getNroVuelo();
        }


    }
}

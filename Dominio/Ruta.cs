using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    //    Las rutas que cubre la aerolínea son entre aeropuertos conocidos.De las rutas se conoce su id autoincremental,
    //aeropuerto de salida, aeropuerto de llegada y distancia.De los aeropuertos se conoce su código IATA
    //(identificador único de 3 letras), ciudad, costo de operación y costo de las tasas.
    public class Ruta
    {
        private static int _idNext=1;

        private int _id;
        private Aeropuerto _aeropuertoSalida;
        private Aeropuerto _aeropuertoEntrada;
        private decimal _distancia;

        public int Id { get { return _id; } }

        private string getIdAeAs ()
        {
            string iataE = this._aeropuertoEntrada.GetIata();
            string iataS = this._aeropuertoSalida.GetIata();
            return $"ID:{this._id} | {iataS}-{iataE}";
        }

        public string GetIdAeAs()
        {
            return getIdAeAs();
        }
        public Aeropuerto AeropuertoSalida
        {
            get { return this._aeropuertoSalida; }
            set { this._aeropuertoSalida = value; }
        }
        public Aeropuerto AeropuertoEntrada
        {
            get { return this._aeropuertoEntrada; }
            set { this._aeropuertoEntrada = value; }
        }
        public decimal Distancia { get { return this._distancia; } set { this._distancia = value; } }

        public Ruta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoEntrada, decimal distancia)
        {
            this._id = _idNext++;
            this._aeropuertoSalida= aeropuertoSalida;
            this._aeropuertoEntrada= aeropuertoEntrada;
            this._distancia= distancia;
        }
        public Ruta() { }

        private int getId()
        {
            return this._id;
        }

        public int GetId()
        {
            return getId();
        }
        private decimal getDistancia()
        {
            return this._distancia;
        }
        public decimal GetDistancia()
        {
            return getDistancia();
        }

        private Aeropuerto getAeropuertoE()
        {
            return this._aeropuertoEntrada;
        }
        public Aeropuerto GetAeropuertoE()
        {
            return getAeropuertoE();
        }

        private Aeropuerto getAeropuertoS()
        {
            return this._aeropuertoSalida;
        }

        public Aeropuerto GetAeropuertoS()
        {
            return getAeropuertoS();
        }
        public override string ToString()
        {
            return $"\nId:{this._id}\nAeropuerto salida:{this._aeropuertoSalida}\nAeropuerto entrada:{this._aeropuertoEntrada}\nDistancia:{this._distancia}";
        }


    }
}

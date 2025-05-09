using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aeropuerto
    {
        private static int _nextId = 1;
        private int _id;
        private string _iata;
        private string _ciudad;
        private decimal _costoOperacion;
        private decimal _costoTasa;

        public string Iata {  get { return _iata; } set { _iata = value; } }
        public string Ciudad { get { return _ciudad; } set { _ciudad = value; } }
        public decimal CostoOperacion { get { return _costoOperacion; } set { _costoOperacion = value; } }
        public decimal CostoTasa {get {return _costoTasa; } set {_costoTasa = value; } }

        public Aeropuerto(string iata,string ciudad,decimal costoOperacion,decimal costoTasa)
        {
            this._id = _nextId++;
            this._iata = iata;
            this._ciudad = ciudad;
            this._costoOperacion = costoOperacion;
            this._costoTasa = costoTasa;
        }
        public Aeropuerto() { }

        public override string ToString()
        {
            return $"\nCodigo IATA:{this._iata}\nCiudad:{this._ciudad}\nCosto Operacion:{this._costoOperacion}\nCosto de tasa:{this._costoTasa}\n";
        }
        private string getIata()
        {
            return this._iata;
        }

        public string GetIata()
        {
            return getIata();
        }

        private int getId()
        {
            return this._id;
        }
        public int GetId()
        {
            return getId();
        }

        private decimal getCostoOperacion()
        {
            return this._costoOperacion;
        }
        public decimal GetCostoOperacion()
        {
            return getCostoOperacion();    
        }
        private decimal getCostoTasa()
        {
            return this._costoTasa;
        }
        public decimal GetCostoTasa()
        {
            return getCostoTasa();
        }
        private string getCodigo()
        {
            return this._iata;
        }
        public string GetCodigo()
        {
            return getCodigo();
        }
    }
}

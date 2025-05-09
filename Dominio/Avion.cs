using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Avion
    {
        private static int _nextId = 1;

        private int _id;
        private string _fabricante;
        private string _modelo;
        private int _cantAsientos;
        private decimal _alcanceKm;
        private decimal _costoKm;

        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int CantAsientos { get; set; }
        public decimal AlcanceKm { get; set; }
        public decimal CostoKm { get; set; }

        public Avion(string fabricante, string modelo, int cantAsientos, decimal alcanceKm,decimal costoKm)
        {
            this._id = _nextId++;
            this._fabricante = fabricante;
            this._modelo = modelo;
            this._cantAsientos = cantAsientos;
            this._alcanceKm = alcanceKm;
            this._costoKm = costoKm;
        }
        public Avion() { }

        private string getModelo()
        {
            return this._modelo;
        }
        public string GetModelo()
        {
            return getModelo();
        }

        private decimal getCostoKm()
        {
            return this._costoKm;
        }
        public decimal GetCostoKm()
        {
            return getCostoKm();
        }

        private int getId()
        {
            return this._id;
        }

        public int GetId()
        {
            return getId();
        }

        private int getCantAsientos()
        {
            return this._cantAsientos;
        }
        public int GetCantAsientos()
        {
            return getCantAsientos();
        }

        private string getIFC()
        {
            return $"ID:{this._id} | Fabricante: {this._fabricante} | Modelo: {this._modelo}";
        }

        public string GetIFC()
        {
            return getIFC();
        }
        public override string ToString()
        {
            return $"ID:{this._id}\nEl fabricante es: {this._fabricante}\nEl modelo es: {this._modelo}\nLa cantidad de asientos es: {this._cantAsientos}\nEl Alcance(km) es: {this._alcanceKm}\nEl costo(km) es: {this._costoKm}\n";
        }

    }
}

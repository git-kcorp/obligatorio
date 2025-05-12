using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Dominio
{
    public class Pasaje
    {
        //UML CREADO
        private static int _nextId=1;
        private int _id;
        private Vuelo _vuelo;
        private DateTime _date;
        private Cliente _pasajero;
        private Equipaje _equipaje;
        private decimal _precio;

        public int Id {get {return _id;}}
        public Vuelo Vuelo { get {return _vuelo;} set{ this._vuelo = value; } }
        public DateTime Date {get {return _date;}set { this._date = value; } }
        public Cliente Pasajero { get { return _pasajero; } set{ this._pasajero = value; } }
        public Equipaje Equipaje { get { return _equipaje; } set { this._equipaje = value; } }
        public decimal Precio { get { return _precio; }set { _precio = value; } }

        public Pasaje(Vuelo vuelo, DateTime date, Cliente pasajero, Equipaje equipaje, decimal precio)
        {
            this._id = _nextId++;
            this._vuelo=vuelo;
            this._date = date;
            this._pasajero=pasajero;
            this._equipaje=equipaje;
            this._precio = precio;
        }
        public Pasaje() { }

        private int getId()
        {
            return this._id;
        }

        public int GetId()
        {
            return getId();
        }

        private DateTime getFecha()
        {
            return this._date;
        }

        public DateTime GetFecha()
        {
            return getFecha();
        }

        public override string ToString()
        {
            return $"\nID:{this._id}\nNombre:{this._pasajero.GetNombre()}\nPrecio:{Math.Round(this._precio,2)}\nFecha:{this._date.ToShortDateString()}\nNro. Vuelo:{this._vuelo.GetNroVuelo()}\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Sistema
    {
        //UML HECHO
        private static Sistema _instancia;

        public static Sistema Instancia
        {
            get {
                if(_instancia == null) _instancia = new Sistema();
                return _instancia;
            }
        }

        private Sistema() { }

        private List<Administrador> _administradores = new List<Administrador>();
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Avion> _aviones = new List<Avion>();
        private List<Aeropuerto> _aeropuertos = new List<Aeropuerto>();
        private List<Ruta> _rutas = new List<Ruta>();
        private List<Vuelo> _vuelos = new List<Vuelo>();
        private List<Pasaje> _pasajes = new List<Pasaje>();

        public Ocacional createClienteOcacional(string mail, string user, string password, int ci, string nombre, string nacionalidad)
        {
            Ocacional cli = new Ocacional(mail, user, password, ci, nombre, nacionalidad);
            if (checkClient(cli,_clientes))
            {
                _clientes.Add(cli);
            }
            return cli;
        }

        private static bool checkClient(Cliente clie, List<Cliente> clientes)
        {
            foreach (Cliente cl in clientes)
            {
                if (cl.GetCi() == clie.GetCi()) throw new Exception("La cedula ya esta registrada.");
                if (cl.GetMail() == clie.GetMail()) throw new Exception("El mail ya esta registrado");
            }
            if (clie.GetCi().ToString().Length != 8) throw new Exception("La cantidad de caracteres en la cedula debe de ser 8.");
            if (String.IsNullOrEmpty(clie.GetMail())) throw new Exception("Ningun mail fue introducido");
            if (!clie.GetMail().Contains("@")) throw new Exception("El mail debe contener un arroba");
            if (String.IsNullOrEmpty(clie.GetNombre())) throw new Exception("Ningun nombre fue introducido");
            if (String.IsNullOrEmpty(clie.GetNacionalidad())) throw new Exception("Ninguna nacionalidad fue introducida");
            if (String.IsNullOrEmpty(clie.GetUser())) throw new Exception("Ningun User fue introducido");
            if (String.IsNullOrEmpty(clie.GetPassword())) throw new Exception("Ninguna contraseña fue introducida");
            return true;
        }

        public Premium createClientePremium(string mail, string user, string password, int ci, string nombre, string nacionalidad)
        {
            Premium cli = new Premium(mail, user, password, ci, nombre, nacionalidad);
            if (checkClient(cli, _clientes))
            {
                _clientes.Add(cli);
            }
            return cli;
        }

        public List<Vuelo> getAllVuelos()
        {
            return _vuelos;
        }
        public List<Ruta> getAllRutas()
        {
            return _rutas;
        }

        public List<Pasaje> listarPasajesEntreFechas(DateTime fecha1, DateTime fecha2)
        {
            List<Pasaje> listadoNew = new List<Pasaje>();
            foreach (Pasaje pasaje in _pasajes)
            {
                if (fecha1.CompareTo(pasaje.GetFecha()) <= 0 && fecha2.CompareTo(pasaje.GetFecha()) >=0)
                {
                    listadoNew.Add(pasaje);
                }
            }
            return listadoNew;
        }

        public List<Avion> GetAllAviones()
        {
            return _aviones;
        }

        public List<Aeropuerto> GetAllAeropuertos()
        {
            return _aeropuertos;
        }

        public string GetDataAdmin(int idAdmin)
        {
            foreach (var admin in _administradores)
            {
                if(admin.Id == idAdmin)
                {
                    return admin.ToString();
                }
            }
            return "ERROR al encontrar administrador";
        }

        public string GetDataCliente(int idCliente)
        {
            foreach (var cliente in _clientes)
            {
                if (cliente.Id == idCliente)
                {
                    return cliente.ToString();
                }
            }
            return "ERROR al encontrar el cliente";
        }
       
        public List<Vuelo> getAllVuelosPorCodigoAeropuerto(string codigo)
        {
            List<Vuelo> vuelosNew = new List<Vuelo>();
            foreach (Vuelo vuelo in _vuelos)
            {
                if(vuelo.GetRuta().GetAeropuertoE().GetCodigo().ToLower() == codigo.ToLower())
                {
                    vuelosNew.Add(vuelo);
                }
                if(vuelo.GetRuta().GetAeropuertoS().GetCodigo().ToLower() == codigo.ToLower())
                {
                    vuelosNew.Add(vuelo);
                }
            }
            return vuelosNew;
        }

        public List<Cliente> getAllClientes()
        {
            return _clientes;
        }

        public void createAdmin(string mail, string user,string password,string apodo)
        {
            Administrador adm = new Administrador(mail,user, password, apodo);
            this._administradores.Add(adm);
        }

        public void createCliente(string mail,string user,string password, int ci, string nombre, string nacionalidad)
        {
            Cliente cli = new Cliente(mail,user,password,ci,nombre,nacionalidad);
            _clientes.Add(cli);
        }

        public Avion createAvion(string fabricante, string modelo, int cantAsientos, decimal alcanceKm, decimal costoKm)
        {
            Avion av = new Avion(fabricante,modelo,cantAsientos,alcanceKm,costoKm);
            _aviones.Add(av);
            return av;
        }

        public Aeropuerto createAeropuerto(string iata, string ciudad, decimal costoOperacion, decimal costoTasa)
        {
            Aeropuerto aeropuerto = new Aeropuerto(iata,ciudad,costoOperacion,costoTasa);
            _aeropuertos.Add(aeropuerto);
            return aeropuerto;
        }

        public Ruta createRuta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoEntrada, decimal distancia)
        {
            Ruta ruta = new Ruta(aeropuertoSalida,aeropuertoEntrada,distancia);
            _rutas.Add(ruta);
            return ruta;
        }

        public Vuelo createVuelo(string numeroVuelo, Ruta ruta, Avion avion, List<FrecuenciaVuelo> frecuencia)
        {
            Vuelo vuelo = new Vuelo(numeroVuelo, ruta, avion, frecuencia);
            _vuelos.Add(vuelo);
            return vuelo;

        }

        public Pasaje createPasaje(Vuelo vuelo, DateTime date, Cliente pasajero, Equipaje equipaje)
        {
            decimal precioAsiento = getPrecioAsiento(vuelo);
            decimal costo = precioAsiento + precioAsiento * 0.25m;
            if(equipaje == Equipaje.CABINA)
            {
                costo = costo + costo * 0.10m;
            }else if(equipaje == Equipaje.BODEGA)
            {
                if (pasajero is Premium)
                {
                    costo = costo + costo * 0.05m;
                }
                else if (pasajero is Ocacional)
                {
                    costo = costo + costo * 0.20m;
                }
            }

            decimal costoTasaE = vuelo.GetRuta().GetAeropuertoE().GetCostoTasa();
            decimal costoTasaS = vuelo.GetRuta().GetAeropuertoS().GetCostoTasa();

            costo += costoTasaE + costoTasaS;

            Pasaje pasaje = new Pasaje(vuelo, date, pasajero, equipaje, costo);
            _pasajes.Add(pasaje);
            return pasaje;
        }

        public Pasaje getPasaje(int id)
        {
            foreach (var pasaje in _pasajes)
            {
                if (pasaje.GetId() == id)
                {
                    return pasaje;
                }
            }
            return null;
        }

        public Vuelo getVuelo(int id)
        {
            foreach (var vuelo in _vuelos)
            {
                if (vuelo.GetId() == id)
                {
                    return vuelo;
                }
            }
            return null;
        }

        public Ruta getRuta(int id)
        {
            foreach (var ruta in _rutas)
            {
                if (ruta.GetId() == id)
                {
                    return ruta;
                }
            }
            return null;
        }

        public Aeropuerto GetAeropuertoIata(string iata)
        {
            foreach (Aeropuerto aeropuerto in _aeropuertos)
            {
                if(aeropuerto.GetIata() == iata)
                {
                    return aeropuerto;
                }
            }
            return null;
        }

        public Aeropuerto GetAeropuerto(int id)
        {
            foreach (var aeropuerto in _aeropuertos)
            {
                if (aeropuerto.GetId() == id)
                {
                    return aeropuerto;
                }
            }
            return null;
        }

        public Avion getAvion(int id)
        {
            foreach (var avion in _aviones)
            {
                if(avion.GetId() == id)
                {
                    return avion;
                }
            }
            return null;
        }

        public Administrador getAdministrador(int id)
        {
            foreach (var adm in _administradores)
            {
                if(adm.getId() == id)
                {
                    return adm;
                }
            }
            return null;
        }

        public Cliente getCliente(int id)
        {
            foreach (var cli in _clientes)
            {
                if (cli.getId() == id)
                {
                    return cli;
                }
            }
            return null;
        }

        public decimal getPrecioAsiento(Vuelo vuelo)
        {
            //(costoKm * distanciaRuta + costoOperacion + costoOperacion )/cantAsientos = precio por asiento

            Avion avion = vuelo.GetAvion();
            decimal costoKm = avion.GetCostoKm();

            Ruta rutaVuelo = vuelo.GetRuta();
            decimal distancia = rutaVuelo.GetDistancia();

            Aeropuerto aeropuertoE = rutaVuelo.GetAeropuertoE();
            Aeropuerto aeropuertoS = rutaVuelo.GetAeropuertoS();

            decimal costoAeropuertoE = aeropuertoE.GetCostoOperacion();
            decimal costoAeropuertoS = aeropuertoS.GetCostoOperacion();

            int cantidadAsientos = avion.GetCantAsientos();

            decimal total = (costoKm * distancia + costoAeropuertoE + costoAeropuertoS) / cantidadAsientos;

            return total;
        }
    }
}

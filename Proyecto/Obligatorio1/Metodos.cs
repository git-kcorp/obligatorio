﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Obligatorio1
{
    public class Metodos
    {
        public static void isAdmin(bool isAdmin,Sistema system,int user_logged)
        {
            if (isAdmin)
            {
                Console.WriteLine(system.GetDataAdmin(user_logged));
            }
            else
            {
                Console.WriteLine(system.GetDataCliente(user_logged));
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void listarPasajesEntreFechas(Sistema system)
        {
            DateTime fecha1;
            DateTime fecha2;
            Console.WriteLine("Ingrese la primera fecha");
            try
            {
                fecha1 = DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("La fecha ingresada es invalida");
            }
            if (fecha1 == null) throw new Exception("La fecha no es valida");
            Console.WriteLine("Ingrese la segunda fecha");
            try
            {
                fecha2 = DateTime.Parse(Console.ReadLine());

            }
            catch
            {
                throw new Exception("La fecha infresada es invalida");
            }
            if (fecha2 == null) throw new Exception("La fecha no es valida");
            List<Pasaje> newLista = system.listarPasajesEntreFechas(fecha1, fecha2);
            Console.Clear();
            Console.WriteLine("Pasajes entre fechas\n");
            foreach (Pasaje pasaje in newLista)
            {
                Console.WriteLine(pasaje.ToString());
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void getAllClientes(Sistema system)
        {
            foreach (var item in system.getAllClientes())
            {
                Console.WriteLine($"{item.ToString()}\n");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void altaCliente(Sistema system)
        {
            try
            {
                Console.WriteLine("Ingrese el mail del cliente");
                string mail = Console.ReadLine();
                if (String.IsNullOrEmpty(mail)) throw new Exception("No se ingreso un mail");
                Console.WriteLine("Ingrese el usuario del cliente");
                string user = Console.ReadLine();
                if (String.IsNullOrEmpty(user)) throw new Exception("No se ingreso un usuario");
                Console.WriteLine("Ingrese la password del cliente");
                string password = Console.ReadLine();
                if (String.IsNullOrEmpty(password)) throw new Exception("No se ingreso una contraseña");
                Console.WriteLine("Ingrese el documento del cliente");
                int ci = 0;
                try
                {
                    ci = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    new Exception("Ingrese datos validos");
                }
                Console.WriteLine("Ingrese el nombre del cliente");
                string nombre = Console.ReadLine();
                if (String.IsNullOrEmpty(nombre)) throw new Exception("No se ingreso una conrtaseña");
                Console.WriteLine("Ingrese la nacionalidad del cliente");
                string nacionalidad = Console.ReadLine();
                if (String.IsNullOrEmpty(nacionalidad)) throw new Exception("No se ingreso una conrtaseña");
                Cliente createdCli = system.createClienteOcacional(mail, user, password, ci, nombre, nacionalidad);
                Console.Clear();
                Console.WriteLine("Se ha creado satisfactoriamente el cliente!");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public static void getAllVuelosPorCodigoAeropuerto(Sistema system)
        {
            Console.WriteLine("Ingrese el codigo IATA");
            string IATA = Console.ReadLine();
            if (String.IsNullOrEmpty(IATA)) throw new Exception("No ingreso el codigo IATA");
            foreach (var item in system.getAllVuelosPorCodigoAeropuerto(IATA))
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        public static void altaAeropuerto(Sistema system)
        {
            Console.WriteLine("Ingrese un codigo IATA para el aeropuerto.");
            string cIata = Console.ReadLine();
            Console.WriteLine("Ingrese en que ciudad esta el aeropuerto");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Ingrese el costo de opracion del aeropuerto");
            decimal costoOp = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo de tasa del aeropuerto");
            decimal costoTasa = Decimal.Parse(Console.ReadLine());
            system.createAeropuerto(cIata, ciudad, costoOp, costoTasa);

            Console.Clear();
            Console.WriteLine("Se ha creado satisfactoriamente el aeropuerto!");
            Console.ReadKey();
        }

        public static void getAllAeropuertos(Sistema system)
        {
            List<Aeropuerto> aeropuertos = system.GetAllAeropuertos();
            Console.WriteLine("Los aeropuertos actuales son:");
            foreach (var aeropuerto in aeropuertos)
            {
                Console.Write(aeropuerto.ToString());
            }
            Console.Clear();
            Console.ReadKey();
            Console.Clear();
        }

        public static void getAllAeropuertosIATA(Sistema system)
        {
            List<Aeropuerto> aeropuertos = system.GetAllAeropuertos();
            foreach (var aeropuerto in aeropuertos)
            {
                Console.Write($"{aeropuerto.GetIata()}\n");
            }

            Console.Clear();
            Console.ReadKey();
            Console.Clear();
        }
        public static void getAllAviones(Sistema system)
        {
            List<Avion> aviones = system.GetAllAviones();
            foreach (var avion in aviones)
            {
                Console.WriteLine(avion.ToString());
            }

            Console.Clear();
            Console.ReadKey();
            Console.Clear();
        }

        public static void getAllAvionesMinimizado(Sistema system)
        {
            List<Avion> aviones = system.GetAllAviones();
            foreach (var avion in aviones)
            {
                Console.WriteLine(avion.GetIFC());
            }

        }


        public static void altaAvion(Sistema system)
        {
            Console.WriteLine("Fabricante de avion:");
            string fabricante = Console.ReadLine();
            Console.WriteLine("Modelo de avion:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Cantidad de asientos:");
            int cantAsientos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Alcance de Kilometros:");
            decimal alcanceKm = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Costo por Kilometro:");
            decimal costoKm = Decimal.Parse(Console.ReadLine());
            system.createAvion(fabricante, modelo, cantAsientos, alcanceKm, costoKm);

            Console.Clear();
            Console.WriteLine("Se ha creado satisfactoriamente el avion!");
            Console.ReadKey();
        }

        public static void listarRutas(Sistema system)
        {
           Console.Clear();
           List<Ruta> rutas= system.getAllRutas();
            foreach (Ruta ruta in rutas)
            {
                Console.WriteLine(ruta.ToString());
            }

            Console.Clear();
            Console.ReadKey();
            Console.Clear();
        }

        public static void altaRuta(Sistema system)
        {
            Console.Clear();
            getAllAeropuertosIATA(system);
            Console.WriteLine("Ingrese el codigo de aeropuerto de salida:\n");
            string iataSalida = Console.ReadLine();
            Console.WriteLine("Ingrese el aeropuerto de salida:\n");
            string iataEntrada = Console.ReadLine();
            Console.WriteLine("Ingrese la distancia entre aeropuertos");
            decimal distancia = Decimal.Parse(Console.ReadLine());

            Aeropuerto aSalida = system.GetAeropuertoIata(iataSalida);
            Aeropuerto aEntrada = system.GetAeropuertoIata(iataEntrada);

            system.createRuta(aSalida, aEntrada, distancia);

            Console.Clear();
            Console.WriteLine("Se ha creado satisfactoriamente la ruta!");
            Console.ReadKey();
        }

        public static void GetAllVuelos(Sistema system)
        {
            Console.Clear();
            List<Vuelo> vuelos = system.getAllVuelos();
            foreach (Vuelo vuelo in vuelos)
            {
                Console.WriteLine(vuelo.ToString());
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void listarRutaMinimizado(Sistema system)
        {
            Console.Clear();
            List<Ruta> rutas = system.getAllRutas();
            foreach (Ruta ruta in rutas)
            {
                Console.WriteLine(ruta.GetIdAeAs());
            }
        }

        public static void altaVuelo(Sistema system)
        {

            Console.Clear();    
            Console.WriteLine("Ingrese el numero de vuelo");

            string numeroVuelo = Console.ReadLine();
            Console.WriteLine("Ingrese el id de la ruta que seguira el vuelo:");
            listarRutaMinimizado(system);

            int idRuta = Int32.Parse(Console.ReadLine());
            Ruta ruta = system.getRuta(idRuta);

            Console.Clear();

            Console.WriteLine("Ingrese id del avion que hara el vuelo");
            getAllAvionesMinimizado(system);
            int idAvion = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Avion avion = system.getAvion(idAvion);
            Console.WriteLine("Ingrese la frecuencia que se hara el vuelo\n");

            Console.WriteLine("1-Lunes");
            Console.WriteLine("2-Martes");
            Console.WriteLine("3-Miercoles");
            Console.WriteLine("4-Jueves");
            Console.WriteLine("5-Viernes");
            Console.WriteLine("6-Sabado");
            Console.WriteLine("7-Domingo");
            Console.WriteLine("0-Terminar");

            List<FrecuenciaVuelo> frecuencias = new List<FrecuenciaVuelo>();

           int frecuencia =-1;

            while (frecuencia != 0)
            {
                frecuencia = Int32.Parse(Console.ReadLine());
                if (frecuencia == 1) frecuencias.Add(FrecuenciaVuelo.Lunes);
                if (frecuencia == 2) frecuencias.Add(FrecuenciaVuelo.Martes);
                if (frecuencia == 3) frecuencias.Add(FrecuenciaVuelo.Miercoles);
                if (frecuencia == 4) frecuencias.Add(FrecuenciaVuelo.Jueves);
                if (frecuencia == 5) frecuencias.Add(FrecuenciaVuelo.Viernes);
                if (frecuencia == 6) frecuencias.Add(FrecuenciaVuelo.Sabado);
                if (frecuencia == 7) frecuencias.Add(FrecuenciaVuelo.Domingo);
            }

            system.createVuelo(numeroVuelo,ruta,avion,frecuencias);

            Console.Clear();
            Console.WriteLine("Se ha creado satisfactoriamente el vuelo!");
            Console.ReadKey();

        }
    }
    
}

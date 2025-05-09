using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Obligatorio1
{
    public class Menus
    {
        public static void menuCliente(Sistema system)
        {
            Console.Clear();
            Console.WriteLine("1-Conseguir informacion de todos los clientes");
            Console.WriteLine("2-Dar alta a un cliente");
            int opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Metodos.getAllClientes(system);
                    break;
                case 2:
                    Metodos.altaCliente(system);
                    break;
            }
        }

        public static void menuAeropuerto(Sistema system)
        {
            Console.Clear();
            Console.WriteLine("1-Conseguir todos los vuelos de un aeropuerto");
            Console.WriteLine("2-Crear un aeropuerto");
            Console.WriteLine("3-Listar Aeropuertos");
            int opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Metodos.getAllVuelosPorCodigoAeropuerto(system);
                    break;

                case 2:
                    Metodos.altaAeropuerto(system);
                    break;

                case 3:
                    Metodos.getAllAeropuertos(system);
                    break;
            }
        }

        public static void menuAviones(Sistema system)
        {
            Console.Clear();
            Console.WriteLine("1-Listar todos los aviones");
            Console.WriteLine("2-Crear un vion");
            int opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Metodos.getAllAviones(system);
                    break;

                case 2:
                    Metodos.altaAvion(system);
                    break;

            }
        }

        public static void menuPasajes(Sistema system)
        {
            Console.Clear();
            Console.WriteLine("1-Listar pasajes entre dos fechas");
            int opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Metodos.listarPasajesEntreFechas(system);
                    break;
            }
        }

        public static void menuRutas(Sistema system)
        {
            Console.Clear();
            Console.WriteLine("1-Listar todas las rutas");
            Console.WriteLine("2-Crear una ruta");
            int opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Metodos.listarRutas(system);
                break;
                case 2:
                    Metodos.altaRuta(system);
                break;
            }

        }
        public static void menuVuelos(Sistema system)
        {
            Console.Clear();
            Console.WriteLine("1-Listar todos los vuelos");
            Console.WriteLine("2-Crear un vuelo");
            int opt = Int32.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Metodos.GetAllVuelos(system);
                    break;
                case 2:
                    Metodos.altaVuelo(system);
                    break;
            }
        }
    }
}

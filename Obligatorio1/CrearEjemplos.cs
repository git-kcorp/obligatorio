using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Obligatorio1
{
    public class CrearEjemplos
    {
        public void crearEjemplos(Sistema system)
        {
            //creacion de admin y cliente
            system.createAdmin("joacoarroba", "joacoUser", "Contrase", "joacoApodo");
            system.createCliente("ezequieltitan", "FireStriper", "201t", 46689505, "ezequiel", "Uruguayo", TipoCliente.ocasional);
            system.createCliente("estimail", "esti", "passEsti", 1233212, "Esteban", "Argentino", TipoCliente.premium);
            Cliente pasajero = system.getCliente(2);

            //creacion de aeropuerto
            system.createAeropuerto("UYU", "montevideo", 80, 17);
            system.createAeropuerto("ARG", "argentina", 120, 12);
            system.createAeropuerto("USA", "Estados Unidos", 77, 24);
            system.createAeropuerto("NIG", "Nigeria", 33, 6);

            Aeropuerto aeropuertoUYU = system.GetAeropuerto(1);
            Aeropuerto aeropuertoARG = system.GetAeropuerto(2);
            Aeropuerto aeropuertoUSA = system.GetAeropuerto(3);
            Aeropuerto aeropuertoNIG = system.GetAeropuerto(4);

            //creacion de ruta
            system.createRuta(aeropuertoUYU, aeropuertoARG, 1000);
            system.createRuta(aeropuertoARG, aeropuertoNIG, 1000);
            system.createRuta(aeropuertoARG, aeropuertoUSA, 1000);
            system.createRuta(aeropuertoUSA, aeropuertoUYU, 1000);

            Ruta rutaUyuArg = system.getRuta(1);
            Ruta rutaArgNig = system.getRuta(2);
            Ruta rutaArgUsa = system.getRuta(3);
            Ruta rutaUsaUyu = system.getRuta(4);

            //creacion de avion
            system.createAvion("Nissan", "modeloJapones", 200, 50, 5);
            Avion avionTest = system.getAvion(1);

            //creacion de vuelo
            system.createVuelo("AA334", rutaUyuArg, avionTest, new List<FrecuenciaVuelo> {FrecuenciaVuelo.Lunes,FrecuenciaVuelo.Martes});
            system.createVuelo("BB445", rutaArgNig, avionTest, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Miercoles, FrecuenciaVuelo.Jueves });
            system.createVuelo("CC556", rutaArgUsa, avionTest, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Viernes, FrecuenciaVuelo.Sabado });
            system.createVuelo("DD667", rutaUsaUyu, avionTest, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Domingo });

            Vuelo vuelo1 = system.getVuelo(1);

            //conseguir precio por asiento
            system.getPrecioAsiento(vuelo1);

            //creacion de pasaje
            system.createPasaje(vuelo1, new DateTime(2003, 09 , 10), pasajero, Equipaje.BODEGA);
            system.createPasaje(vuelo1, new DateTime(2004, 09 , 10), pasajero, Equipaje.BODEGA);
            system.createPasaje(vuelo1, new DateTime(2005, 09 , 10), pasajero, Equipaje.BODEGA);
            system.createPasaje(vuelo1, new DateTime(2006, 09 , 10), pasajero, Equipaje.BODEGA);
            system.createPasaje(vuelo1, new DateTime(2007, 09 , 10), pasajero, Equipaje.BODEGA);
            Pasaje pasajeGenerado = system.getPasaje(1);
        }
    }
}

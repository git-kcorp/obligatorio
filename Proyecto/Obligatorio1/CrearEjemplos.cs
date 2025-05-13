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
            system.createAdmin("joaco@zionbancorp.com", "joaco", "pass", "joacoApodo");
            system.createAdmin("isma@microsoft.com", "isma", "pass", "ismaApodo");
            //CREA OCACIONALES
            Cliente pasajero1 = system.createClienteOcacional("ezequieltitan@hotmail.com", "eze", "pass", 46689505, "Ezequiel", "Uruguayo");
            Cliente pasajero2 = system.createClienteOcacional("sofia@mail.com", "sofi", "1234", 45321231, "Sofia", "Uruguaya");
            Cliente pasajero3 = system.createClienteOcacional("marco@mail.com", "marco123", "abcd", 48976543, "Marco", "Chileno");
            Cliente pasajero4 = system.createClienteOcacional("lucia@mail.com", "lucy", "qwerty", 45511222, "Lucia", "Paraguaya");
            Cliente pasajero5 = system.createClienteOcacional("diego@mail.com", "dieguito", "zxcv", 44112233, "Diego", "Boliviano");
            //CREA PREMIUM
            Cliente pasajero6 = system.createClientePremium("estimail@premium.com", "esti", "pass", 12332126, "Esteban", "Argentino");
            Cliente pasajero7 = system.createClientePremium("ana@mail.com", "anita", "anapass", 99887766, "Ana", "Uruguaya");
            Cliente pasajero8 = system.createClientePremium("jose@mail.com", "jose", "josito", 11223344, "Jose", "Peruano");
            Cliente pasajero9 = system.createClientePremium("carla@mail.com", "carli", "car123", 55667788, "Carla", "Venezolana");
            Cliente pasajero10 = system.createClientePremium("nicolas@mail.com", "nico", "nicopass", 77889900, "Nicolas", "Colombiano");
            //creacion de aeropuerto
            Aeropuerto aeropuertoUYU = system.createAeropuerto("UYU", "Montevideo", 80, 17);
            Aeropuerto aeropuertoARG = system.createAeropuerto("ARG", "Buenos Aires", 120, 12);
            Aeropuerto aeropuertoUSA = system.createAeropuerto("USA", "New York", 77, 24);
            Aeropuerto aeropuertoNIG = system.createAeropuerto("NIG", "Lagos", 33, 6);
            Aeropuerto aeropuertoBRA = system.createAeropuerto("BRA", "Rio de Janeiro", 95, 15);
            Aeropuerto aeropuertoMEX = system.createAeropuerto("MEX", "Ciudad de México", 85, 13);
            Aeropuerto aeropuertoCAN = system.createAeropuerto("CAN", "Toronto", 105, 18);
            Aeropuerto aeropuertoFRA = system.createAeropuerto("FRA", "Frankfurt", 150, 22);
            Aeropuerto aeropuertoESP = system.createAeropuerto("ESP", "Madrid", 110, 14);
            Aeropuerto aeropuertoITA = system.createAeropuerto("ITA", "Roma", 100, 16);
            Aeropuerto aeropuertoCHL = system.createAeropuerto("CHL", "Santiago", 90, 11);
            Aeropuerto aeropuertoPER = system.createAeropuerto("PER", "Lima", 88, 10);
            Aeropuerto aeropuertoCOL = system.createAeropuerto("COL", "Bogotá", 87, 9);
            Aeropuerto aeropuertoVEN = system.createAeropuerto("VEN", "Caracas", 70, 8);
            Aeropuerto aeropuertoURU = system.createAeropuerto("URU", "Punta del Este", 60, 7);
            Aeropuerto aeropuertoUK  =  system.createAeropuerto("UK", "Londres", 140, 25);
            Aeropuerto aeropuertoJPN = system.createAeropuerto("JPN", "Tokio", 160, 30);
            Aeropuerto aeropuertoCHN = system.createAeropuerto("CHN", "Pekín", 155, 28);
            Aeropuerto aeropuertoAUS = system.createAeropuerto("AUS", "Sídney", 145, 20);
            Aeropuerto aeropuertoIND = system.createAeropuerto("IND", "Nueva Delhi", 130, 19);
            //creacion de ruta
            Ruta rutaUyuArg = system.createRuta(aeropuertoUYU, aeropuertoARG, 1000);
            Ruta rutaUyuBra = system.createRuta(aeropuertoUYU, aeropuertoBRA, 1800);
            Ruta rutaUyuChl = system.createRuta(aeropuertoUYU, aeropuertoCHL, 1600);
            Ruta rutaArgUsa = system.createRuta(aeropuertoARG, aeropuertoUSA, 8500);
            Ruta rutaArgFra = system.createRuta(aeropuertoARG, aeropuertoFRA, 11000);
            Ruta rutaArgEsp = system.createRuta(aeropuertoARG, aeropuertoESP, 10200);
            Ruta rutaBraMex = system.createRuta(aeropuertoBRA, aeropuertoMEX, 7400);
            Ruta rutaBraNig = system.createRuta(aeropuertoBRA, aeropuertoNIG, 6800);
            Ruta rutaChlPer = system.createRuta(aeropuertoCHL, aeropuertoPER, 2500);
            Ruta rutaChlCol = system.createRuta(aeropuertoCHL, aeropuertoCOL, 2700);
            Ruta rutaMexCan = system.createRuta(aeropuertoMEX, aeropuertoCAN, 3600);
            Ruta rutaCanUsa = system.createRuta(aeropuertoCAN, aeropuertoUSA, 800);
            Ruta rutaUsaFra = system.createRuta(aeropuertoUSA, aeropuertoFRA, 5900);
            Ruta rutaUsaEsp = system.createRuta(aeropuertoUSA, aeropuertoESP, 6100);
            Ruta rutaUsaIta = system.createRuta(aeropuertoUSA, aeropuertoITA, 7000);
            Ruta rutaFraUk = system.createRuta(aeropuertoFRA, aeropuertoUK, 900);
            Ruta rutaEspUk = system.createRuta(aeropuertoESP, aeropuertoUK, 1300);
            Ruta rutaUkJpn = system.createRuta(aeropuertoUK, aeropuertoJPN, 9700);
            Ruta rutaUkChn = system.createRuta(aeropuertoUK, aeropuertoCHN, 8900);
            Ruta rutaJpnAus = system.createRuta(aeropuertoJPN, aeropuertoAUS, 7800);
            Ruta rutaChnInd = system.createRuta(aeropuertoCHN, aeropuertoIND, 4800);
            Ruta rutaIndAus = system.createRuta(aeropuertoIND, aeropuertoAUS, 10100);
            Ruta rutaIndNig = system.createRuta(aeropuertoIND, aeropuertoNIG, 7500);
            Ruta rutaNigVen = system.createRuta(aeropuertoNIG, aeropuertoVEN, 9200);
            Ruta rutaVenCol = system.createRuta(aeropuertoVEN, aeropuertoCOL, 1600);
            Ruta rutaColPer = system.createRuta(aeropuertoCOL, aeropuertoPER, 1800);
            Ruta rutaPerEsp = system.createRuta(aeropuertoPER, aeropuertoESP, 9600);
            Ruta rutaCanFra = system.createRuta(aeropuertoCAN, aeropuertoFRA, 6000);
            Ruta rutaUyuUk = system.createRuta(aeropuertoUYU, aeropuertoUK, 11400);
            Ruta rutaEspJpn = system.createRuta(aeropuertoESP, aeropuertoJPN, 10800);

            //creacion de avion
            Avion primerAvion = system.createAvion("Nissan", "modeloJapones", 200, 50, 5);
            Avion segundoAvion = system.createAvion("Boeing", "737 Max", 180, 6500, 8.5m);
            Avion tercerAvion = system.createAvion("Airbus", "A320neo", 190, 6100, 8.0m);
            Avion cuartoAvion = system.createAvion("Embraer", "E195-E2", 132, 4800, 6.5m);

            //creacion de vuelo
            Vuelo vuelo1 = system.createVuelo("AA334", rutaUyuArg, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Lunes, FrecuenciaVuelo.Martes });
            Vuelo vuelo2 = system.createVuelo("BB101", rutaUyuBra, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Miercoles, FrecuenciaVuelo.Viernes });
            Vuelo vuelo3 = system.createVuelo("CC202", rutaUyuChl, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Martes, FrecuenciaVuelo.Sabado });
            Vuelo vuelo4 = system.createVuelo("DD303", rutaArgUsa, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Domingo });
            Vuelo vuelo5 = system.createVuelo("EE404", rutaArgFra, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Jueves });
            Vuelo vuelo6 = system.createVuelo("FF505", rutaArgEsp, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Martes, FrecuenciaVuelo.Viernes });
            Vuelo vuelo7 = system.createVuelo("GG606", rutaBraMex, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Lunes });
            Vuelo vuelo8 = system.createVuelo("HH707", rutaBraNig, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Miercoles, FrecuenciaVuelo.Sabado });
            Vuelo vuelo9 = system.createVuelo("II808", rutaChlPer, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Domingo });
            Vuelo vuelo10 = system.createVuelo("JJ909", rutaChlCol, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Lunes });
            Vuelo vuelo11 = system.createVuelo("KK111", rutaMexCan, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Miercoles, FrecuenciaVuelo.Jueves });
            Vuelo vuelo12 = system.createVuelo("LL222", rutaCanUsa, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Viernes });
            Vuelo vuelo13 = system.createVuelo("MM333", rutaUsaFra, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Martes, FrecuenciaVuelo.Jueves });
            Vuelo vuelo14 = system.createVuelo("NN444", rutaUsaEsp, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Sabado });
            Vuelo vuelo15 = system.createVuelo("OO555", rutaUsaIta, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Domingo });
            Vuelo vuelo16 = system.createVuelo("PP666", rutaFraUk, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Lunes });
            Vuelo vuelo17 = system.createVuelo("QQ777", rutaEspUk, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Jueves });
            Vuelo vuelo18 = system.createVuelo("RR888", rutaUkJpn, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Viernes, FrecuenciaVuelo.Sabado });
            Vuelo vuelo19 = system.createVuelo("SS999", rutaUkChn, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Miercoles });
            Vuelo vuelo20 = system.createVuelo("TT000", rutaJpnAus, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Martes });
            Vuelo vuelo21 = system.createVuelo("UU121", rutaChnInd, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Lunes });
            Vuelo vuelo22 = system.createVuelo("VV232", rutaIndAus, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Domingo });
            Vuelo vuelo23 = system.createVuelo("WW343", rutaIndNig, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Miercoles });
            Vuelo vuelo24 = system.createVuelo("XX454", rutaNigVen, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Jueves });
            Vuelo vuelo25 = system.createVuelo("YY565", rutaVenCol, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Sabado });
            Vuelo vuelo26 = system.createVuelo("ZZ676", rutaColPer, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Lunes, FrecuenciaVuelo.Miercoles });
            Vuelo vuelo27 = system.createVuelo("AB787", rutaPerEsp, cuartoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Viernes });
            Vuelo vuelo28 = system.createVuelo("BC898", rutaCanFra, primerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Domingo });
            Vuelo vuelo29 = system.createVuelo("CD909", rutaUyuUk, segundoAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Martes, FrecuenciaVuelo.Jueves });
            Vuelo vuelo30 = system.createVuelo("DE010", rutaEspJpn, tercerAvion, new List<FrecuenciaVuelo> { FrecuenciaVuelo.Sabado });

            //creacion de pasaje
            Pasaje pasaje1 = system.createPasaje(vuelo1, new DateTime(2003, 09, 10), pasajero1, Equipaje.BODEGA);
            Pasaje pasaje2 = system.createPasaje(vuelo2, new DateTime(2004, 10, 12), pasajero2, Equipaje.LIGHT);
            Pasaje pasaje3 = system.createPasaje(vuelo3, new DateTime(2005, 11, 14), pasajero3, Equipaje.CABINA);
            Pasaje pasaje4 = system.createPasaje(vuelo4, new DateTime(2006, 12, 16), pasajero4, Equipaje.LIGHT);
            Pasaje pasaje5 = system.createPasaje(vuelo5, new DateTime(2007, 01, 18), pasajero5, Equipaje.BODEGA);
            Pasaje pasaje6 = system.createPasaje(vuelo6, new DateTime(2008, 02, 20), pasajero6, Equipaje.CABINA);
            Pasaje pasaje7 = system.createPasaje(vuelo7, new DateTime(2009, 03, 22), pasajero7, Equipaje.BODEGA);
            Pasaje pasaje8 = system.createPasaje(vuelo8, new DateTime(2010, 04, 24), pasajero8, Equipaje.LIGHT);
            Pasaje pasaje9 = system.createPasaje(vuelo9, new DateTime(2011, 05, 26), pasajero9, Equipaje.CABINA);
            Pasaje pasaje10 = system.createPasaje(vuelo10, new DateTime(2012, 06, 28), pasajero10, Equipaje.BODEGA);
            Pasaje pasaje11 = system.createPasaje(vuelo11, new DateTime(2013, 07, 30), pasajero1, Equipaje.LIGHT);
            Pasaje pasaje12 = system.createPasaje(vuelo12, new DateTime(2014, 08, 02), pasajero2, Equipaje.CABINA);
            Pasaje pasaje13 = system.createPasaje(vuelo13, new DateTime(2015, 09, 04), pasajero3, Equipaje.BODEGA);
            Pasaje pasaje14 = system.createPasaje(vuelo14, new DateTime(2016, 10, 06), pasajero4, Equipaje.LIGHT);
            Pasaje pasaje15 = system.createPasaje(vuelo15, new DateTime(2017, 11, 08), pasajero5, Equipaje.CABINA);
            Pasaje pasaje16 = system.createPasaje(vuelo16, new DateTime(2018, 12, 10), pasajero6, Equipaje.BODEGA);
            Pasaje pasaje17 = system.createPasaje(vuelo17, new DateTime(2019, 01, 12), pasajero7, Equipaje.LIGHT);
            Pasaje pasaje18 = system.createPasaje(vuelo18, new DateTime(2020, 02, 14), pasajero8, Equipaje.CABINA);
            Pasaje pasaje19 = system.createPasaje(vuelo19, new DateTime(2021, 03, 16), pasajero9, Equipaje.BODEGA);
            Pasaje pasaje20 = system.createPasaje(vuelo20, new DateTime(2022, 04, 18), pasajero10, Equipaje.LIGHT);
            Pasaje pasaje21 = system.createPasaje(vuelo21, new DateTime(2023, 05, 20), pasajero1, Equipaje.CABINA);
            Pasaje pasaje22 = system.createPasaje(vuelo22, new DateTime(2024, 06, 22), pasajero2, Equipaje.BODEGA);
            Pasaje pasaje23 = system.createPasaje(vuelo23, new DateTime(2025, 07, 24), pasajero3, Equipaje.LIGHT);
            Pasaje pasaje24 = system.createPasaje(vuelo24, new DateTime(2026, 08, 26), pasajero4, Equipaje.CABINA);
            Pasaje pasaje25 = system.createPasaje(vuelo25, new DateTime(2027, 09, 28), pasajero5, Equipaje.BODEGA);

        }
    }
}

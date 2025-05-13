using Dominio;

namespace Obligatorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sistema system = Sistema.Instancia;
            CrearEjemplos ejemplos = new CrearEjemplos();
            ejemplos.crearEjemplos(system);

            int opt = -1;
            while (opt != 0)
            {
                try
                {
                    
                    Console.WriteLine("----Menu----");
                            Console.WriteLine("1-Clientes");
                            Console.WriteLine("2-Aeropuertos");
                            Console.WriteLine("3-Pasajes");
                            Console.WriteLine("0-Salir");
                    Console.WriteLine("------------");

                    opt = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opt)
                    {
                        case 1:
                            Menus.menuCliente(system);
                            break;
                        case 2:
                            Menus.menuAeropuerto(system);
                            break;
                        case 3:
                            Menus.menuPasajes(system);

                            break;
                        case 0:
                            Environment.Exit(0);
                         break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}

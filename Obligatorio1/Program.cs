using Dominio;

namespace Obligatorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sistema system = Sistema.Instancia;

            int user_logged = 0;
            bool isAdmin = false;

            CrearEjemplos ejemplos = new CrearEjemplos();
            ejemplos.crearEjemplos(system);

            int opt = -1;
            while (opt != 0)
            {
                try
                {
                    
                    Console.WriteLine("----Menu----");
                    if (user_logged == 0)
                    {
                        Console.WriteLine("1-Loguearse");
                    }
                    else
                    {

                        Console.WriteLine("2-Mostrar informacion del usuario logueado");
                        if (isAdmin)
                        {
                            Console.WriteLine("3-Clientes");
                            Console.WriteLine("4-Aeropuertos");
                            Console.WriteLine("5-Aviones");
                            Console.WriteLine("6-Pasajes");
                            Console.WriteLine("7-Rutas");
                            Console.WriteLine("8-Vuelos");
                        }
                        Console.WriteLine("99-Cerrar sesion");
                    }

                    opt = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opt)
                    {
                        case 1:
                            Metodos.login(ref user_logged, ref isAdmin,ref system);
                            break;
                        case 2:
                            Metodos.isAdmin(isAdmin,system,user_logged);
                            break;
                        case 3:
                            Menus.menuCliente(system);
                            break;
                        case 4:
                            Menus.menuAeropuerto(system);
                            break;
                        case 5:
                            Menus.menuAviones(system);
                            break;
                        case 6:
                            Menus.menuPasajes(system);
                            break;

                        case 7:
                            Menus.menuRutas(system);
                            break;

                        case 8:
                            Menus.menuVuelos(system);
                            break;
                        case 99:
                            user_logged = 0;
                            isAdmin = false;
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

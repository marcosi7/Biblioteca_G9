using System;

namespace Biblioteca_G9
{
    public class Biblioteca
    {
        class Menu
        {
            public static void menuBibliotecario()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[ 1 ] Actualizar Stock");
                    Console.WriteLine("[ 2 ] Contestar Consulta");
                    Console.WriteLine("[ 3 ] Realizar Pedido");
                    Console.WriteLine("[ 4 ] Mostrar Usuarios");
                    Console.WriteLine("[ 0 ] Salir");

                    string input = Console.ReadLine();
                    casos_menuB(input);
                }

            }
            public static void menuCliente()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[ 1 ] Llevar libro");
                    Console.WriteLine("[ 2 ] Devolver libro");
                    Console.WriteLine("[ 3 ] Realizar Consulta");
                    Console.WriteLine("[ 4 ] Realizar Sugerencia");
                    Console.WriteLine("[ 0 ] Salir");

                    string input = Console.ReadLine();
                    casos_menuC(input);
                }

            }
            static void casos_menuB(string input)
            {
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Bibliotecario.actualizarStock();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Bibliotecario.contestarConsulta();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Bibliotecario.hacerPedido();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Bibliotecario.mostrarUsuarios();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.Clear();
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                }
            }
            static void casos_menuC(string input)
            {
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Cliente.llevarLibro();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Cliente.devolverLibro();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Cliente.hacerConsulta();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Cliente.hacerSugerencia();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.Clear();
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ------------------- ");
                Console.WriteLine("|   INGRESAR COMO   |");
                Console.WriteLine(" ------------------- ");
                Console.WriteLine("[ 1 ] Cliente");
                Console.WriteLine("[ 2 ] Bibliotecario");

                string opcion = Console.ReadLine().Trim();

                if (opcion == "")
                {
                    Console.Clear();
                    Console.WriteLine("No hay valor ingresado.");
                    Console.ReadKey();
                }
                else if (opcion == "1")
                {
                    Console.Clear();
                    Menu.menuCliente();
                }
                else if (opcion == "2")
                {
                    Console.Clear();
                    Menu.menuBibliotecario();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un valor correcto.");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
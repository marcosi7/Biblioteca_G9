using System;

namespace Biblioteca_G9
{
    public class Biblioteca
    {
        public class Programa
        {
            public void Menu()
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
                        menuCliente();
                    }
                    else if (opcion == "2")
                    {
                        Console.Clear();
                        menuBibliotecario();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese un valor correcto.");
                        Console.ReadKey();
                    }
                }

            }
            public void menuBibliotecario()
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
                    casos_bibliotecario(input);
                }

            }
            public void menuCliente()
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
                    casos_cliente(input);
                }

            }
            public void casos_bibliotecario(string input)
            {
                Bibliotecario bl = new Bibliotecario();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        bl.actualizarStock();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        bl.contestarConsulta();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        bl.hacerPedido();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        bl.mostrarUsuarios();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.Clear();
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                }
            }
            public void casos_cliente(string input)
            {
                Cliente cl = new Cliente();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        cl.llevarLibro();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        cl.devolverLibro();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        cl.hacerConsulta();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        cl.hacerSugerencia();
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
            Programa programa = new Programa();
            programa.Menu();
        }
    }
}
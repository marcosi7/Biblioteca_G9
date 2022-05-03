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
                    Console.WriteLine(" -------------------------------- ");
                    Console.WriteLine("|   SELECCIONE DE TIPO USUARIO   |");
                    Console.WriteLine(" -------------------------------- ");
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
                Console.Clear();
                Console.WriteLine("Ingrese numero C.I.: ");
                int Nci = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Ingrese Nombres: ");
                string Nnombre = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingrese Apellidos: ");
                string Napellido = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingrese Email: ");
                string Nemail = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingrese Direccion: ");
                string Ndireccion = Console.ReadLine();

                Bibliotecario bl = new Bibliotecario(Nci, Nnombre, Napellido, Nemail, Ndireccion);

                Console.Clear();
                Console.WriteLine(bl);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Registrado Correctamente.", Console.ForegroundColor);
                Console.ReadKey();
                Console.ResetColor();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[ 1 ] Actualizar Stock");
                    Console.WriteLine("[ 2 ] Contestar Consulta");
                    Console.WriteLine("[ 3 ] Realizar Pedido");
                    Console.WriteLine("[ 0 ] Salir");

                    int input = int.Parse(Console.ReadLine());
                    casos_bibliotecario(input, bl);
                }

            }
            public void menuCliente()
            {
                Console.Clear();
                Console.WriteLine("Ingrese numero C.I.: ");
                int Nci = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Ingrese Nombres: ");
                string Nnombre = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingrese Apellidos: ");
                string Napellido = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingrese Email: ");
                string Nemail = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingrese Direccion: ");
                string Ndireccion = Console.ReadLine();

                Cliente cl = new Cliente(Nci, Nnombre, Napellido, Nemail, Ndireccion);

                Console.Clear();
                Console.WriteLine(cl);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Registrado Correctamente.",Console.ForegroundColor);
                Console.ReadKey();
                Console.ResetColor();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[ 1 ] Llevar libro");
                    Console.WriteLine("[ 2 ] Devolver libro");
                    Console.WriteLine("[ 3 ] Realizar Consulta");
                    Console.WriteLine("[ 4 ] Realizar Sugerencia");
                    Console.WriteLine("[ 0 ] Salir");

                    int input = int.Parse(Console.ReadLine());
                    casos_cliente(input, cl);
                }

            }
            public void casos_bibliotecario(int input, Bibliotecario bl)
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(bl);
                        bl.actualizarStock();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(bl);
                        bl.contestarConsulta();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(bl);
                        bl.hacerPedido();
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Clear();
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                }
            }
            public void casos_cliente(int input, Cliente cl)
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        cl.llevarLibro();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        cl.devolverLibro();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        cl.hacerConsulta();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        cl.hacerSugerencia();
                        Console.ReadKey();
                        break;
                    case 0:
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
using System;

namespace Biblioteca_G9
{
    public class Biblioteca
    {
        class Menu
        {
            void menuBibliotecario()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[1] Actualizar Stock");
                    Console.WriteLine("[2] Contestar Consulta");
                    Console.WriteLine("[3] Realizar Pedido");
                    Console.WriteLine("[4] Mostrar Usuarios");
                    Console.WriteLine("[0] Salir");

                    string input = Console.ReadLine();
                    casos_menu(input);
                }

            }
            public static void menuCliente()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[1] Llevar libro");
                    Console.WriteLine("[2] Devolver libro");
                    Console.WriteLine("[3] Realizar Consulta");
                    Console.WriteLine("[4] Realizar Sugerencia");
                    Console.WriteLine("[0] Salir");

                    string input = Console.ReadLine();
                    casos_menu(input);
                }

            }
            static void casos_menu(string input)
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
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.Clear();
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("********* CREACION DE NUEVO USUARIO ******");
            Console.WriteLine("Ingrese C.I.: ");
            int Nci = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Constraseña: ");
            string Ncontraseña = Console.ReadLine();

            Console.WriteLine("Ingrese Nombres: ");
            string Nnombre = Console.ReadLine();

            Console.WriteLine("Ingrese Apellidos: ");
            string Napellido = Console.ReadLine();

            Console.WriteLine("Ingrese Email: ");
            string Nemail = Console.ReadLine();

            Console.WriteLine("Ingrese Direccion: ");
            string Ndireccion = Console.ReadLine();

            Usuario usuario = new Usuario(Nci, Ncontraseña, Nnombre, Napellido, Nemail, Ndireccion);

            Console.WriteLine("Usuario: "+usuario);
            */

            Menu.menuCliente();

            
        }
    }
}
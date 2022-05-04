using System;

namespace Biblioteca_G9
{
    public static class Global
    {
        public static string name="royer";
        public static ListaEnlazada biblioteLibros = new ListaEnlazada();
       

    }
    public class Biblioteca
    {
        public class Programa
        {
            public void Menu()
            {
                /*  VARIBLE GLOBAL DE Lista de libros
                 *  
                 */
                //----
                Console.Clear();

                Libro libro = new Libro("la cabaña", "Raul", "6ta", "Otro", "lumbreras", 2);
               Global.biblioteLibros.Append(libro);
                Libro libro1 = new Libro("mateFacil", "Marcelo", "1ra", "Educativo", "Santillana", 1);
                Global.biblioteLibros.Append(libro1);
                Libro libro2 = new Libro("electronica", "Jose", "3ra", "Educativo", "Bay", 1);
                Global.biblioteLibros.Append(libro2);
                Libro libro3 = new Libro("analisis", "Paola", "2da", "Educativo", "Bay", 1);
                Global.biblioteLibros.Append(libro3);
                Libro libro4 = new Libro("instalaciones", "Renan", "1da", "Educativo", "Lumbreras", 1);
                Global.biblioteLibros.Append(libro4);
                /*Console.WriteLine("-----");
                Console.WriteLine("LIBROS: ");
                Global.biblioteLibros.Display();
                Console.ReadKey();
                Console.Clear();*/
                //Console.WriteLine("-----elimninamos");
                //Global.biblioteLibros.Remove(libro2);
                //Global.biblioteLibros.Remove(libro);
                //Console.WriteLine("LIBROS: ");
                //Global.biblioteLibros.Display();
                //Console.WriteLine(libro.ToString());


                //imprimimos el libro

                //----
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(" -------------------------------- ");
                    Console.WriteLine("|   SELECCIONE DE TIPO USUARIO   |");
                    Console.WriteLine(" -------------------------------- ");
                    Color("1", " Cliente");
                    Color("2", " Bibliotecario");

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
            public static void Color(string prefix, string msj)
            {
                Console.Write("[ ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(prefix, Console.ForegroundColor);
                Console.ResetColor();
                Console.WriteLine(" ]" + msj);
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
                    Color("1", " Agregar Libros");
                    Color("2", " Contestar Consulta");
                    Color("3", " Realizar Pedido");
                    Color("0", " Salir");

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
                    Color("1", " Llevar libro");
                    Color("2", " Devolver libro");
                    Color("3", " Realizar Consulta");
                    Color("4", " Realizar Sugerencia");
                    Color("0", " Salir");

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
                        bl.agregarLibros();
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
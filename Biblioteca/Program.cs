

using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Biblio biblioteca = new Biblio("Biblioteca Central");

        int opcion;
        do
        {
            Console.WriteLine("\n****** MENU ******");
            Console.WriteLine("1. Catálogo de libros");
            Console.WriteLine("2. Prestar libro");
            Console.WriteLine("3. Devolver libro");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            else
            {
                if (opcion == 1)
                {
                    biblioteca.MostrarCatalogo();
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese el título del libro que desea prestar: ");
                    string tituloPrestamo = Console.ReadLine();
                    biblioteca.PrestarLibro(tituloPrestamo);
                   
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el título del libro que desea devolver: ");
                    string tituloDevolucion = Console.ReadLine();
                    biblioteca.DevolverLibro(tituloDevolucion);
                    Console.WriteLine("\n****** Libro devuelto correctamente ******");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, elige una opción del menú.");
                }
            }

        } while (opcion != 4);
    }

}
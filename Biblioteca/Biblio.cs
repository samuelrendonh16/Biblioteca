
using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Biblio
    {
        private string nombre;
        private List<Libro> librosDisponibles;
        private List<Libro> librosPrestados;

        public Biblio(string nombre)
        {
            this.nombre = nombre;
            this.librosDisponibles = new List<Libro>();
            this.librosPrestados = new List<Libro>();
            AgregarLibrosIniciales();
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("Catálogo de Libros Disponibles:");
            foreach (var libro in librosDisponibles)
            {
                Console.WriteLine($"{libro.ObtenerTitulo()} - {libro.ObtenerAutor()}");
            }
        }

        public void PrestarLibro(string titulo)
        {
            Libro libroAPrestar = librosDisponibles.Find(libro => libro.ObtenerTitulo() == titulo);
            if (libroAPrestar != null)
            {
                librosDisponibles.Remove(libroAPrestar);
                librosPrestados.Add(libroAPrestar);
                Console.WriteLine($"El libro \"{titulo}\" ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro \"{titulo}\" no está disponible en la biblioteca.");
            }
        }

        public void DevolverLibro(string titulo)
        {
            Libro libroADevolver = librosPrestados.Find(libro => libro.ObtenerTitulo() == titulo);
            if (libroADevolver != null)
            {
                librosPrestados.Remove(libroADevolver);
                librosDisponibles.Add(libroADevolver);
                Console.WriteLine($"El libro \"{titulo}\" ha sido devuelto.");
            }
            else
            {
                Console.WriteLine($"El libro \"{titulo}\" no está en la lista de libros prestados.");
            }
        }

        private void AgregarLibrosIniciales()
        {
            librosDisponibles.Add(new Libro("El principito", "Antoine de Saint-Exupéry"));
            librosDisponibles.Add(new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling"));
            librosDisponibles.Add(new Libro("Cien años de soledad", "Gabriel García Márquez"));
            librosDisponibles.Add(new Libro("1984", "George Orwell"));
            librosDisponibles.Add(new Libro("Don Quijote de la Mancha", "Miguel de Cervantes"));
        }
    }
}
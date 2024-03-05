using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        // Atributos
        private string titulo;
        private string autor;
    
       

        // Constructor
        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
         
        }

        // Métodos
        public string ObtenerTitulo()
        {
            return titulo;
        }

        public string ObtenerAutor()
        {
            return autor;
        }


        public void EstablecerTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }

        public void EstablecerAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }

      
    }
}

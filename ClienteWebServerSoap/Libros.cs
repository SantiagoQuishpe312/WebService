using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWebServerSoap
{
    // Supongamos que 'Libro' es el namespace del servicio web generado y contiene 'LibrosPortClient'
    public class Libros
    {
        // Clase para representar un libro, basado en la estructura esperada de la respuesta
        public class Libro
        {
            public int ID { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Editorial { get; set; }
            public int AnioPublicacion { get; set; }
            public string ISBN { get; set; }
        }

        // Método para obtener los libros desde el servicio web
        public List<Libro> ObtenerLibros()
        {
            List<Libro> listaLibros = new List<Libro>();

            // Crear el cliente para el servicio web
            ClienteWebServerSoap.Libro.LibrosPortClient objGetLib = new ClienteWebServerSoap.Libro.LibrosPortClient("LibrosPortSoap11");

            try
            {
                // Llamar al método del servicio web para obtener los libros
                var respuesta = objGetLib.getLibro(new ClienteWebServerSoap.Libro.getLibroRequest());

                // Suponiendo que la respuesta contiene una colección de libros
                foreach (var item in respuesta.getLibroResponse1) // Ajustar al nombre real de la colección en la respuesta
                {
                    // Crear un objeto libro basado en la respuesta
                    Libro libro = new Libro
                    {
                        ID = item.ID,
                        Titulo = item.Titulo,
                        Autor = item.Autor,
                        Editorial = item.Editorial,
                        AnioPublicacion = item.AnioPublicacion,
                        ISBN = item.ISBN
                    };

                    // Agregar el libro a la lista
                    listaLibros.Add(libro);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los libros: " + ex.Message);
            }

            return listaLibros;
        }

        // Método para mostrar los libros
        public void MostrarLibros()
        {
            List<Libro> libros = ObtenerLibros();

            foreach (var libro in libros)
            {
                Console.WriteLine($"ID: {libro.ID}, Título: {libro.Titulo}, Autor: {libro.Autor}, Editorial: {libro.Editorial}, Año de Publicación: {libro.AnioPublicacion}, ISBN: {libro.ISBN}");
            }
        }
    }
}

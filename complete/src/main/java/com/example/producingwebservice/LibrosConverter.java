package com.example.producingwebservice;
import io.spring.guides.gs_producing_web_service.Libro;
public class LibrosConverter {
    public static ModelLibros toModelLibros(Libro libro) {
        ModelLibros modelLibros = new ModelLibros();
        modelLibros.setId(libro.getId());
        modelLibros.setTitulo(libro.getTitulo());
        modelLibros.setAutor(libro.getAutor());
        modelLibros.setEditorial(libro.getEditorial());
        modelLibros.setAnoPublicacion(libro.getAnoPublicacion());
        modelLibros.setIsbn(libro.getIsbn());
        return modelLibros;
    }

    public static Libro toLibro(ModelLibros modelLibros) {
        Libro libro = new Libro();
        libro.setId(modelLibros.getId());
        libro.setTitulo(modelLibros.getTitulo());
        libro.setAutor(modelLibros.getAutor());
        libro.setEditorial(modelLibros.getEditorial());
        libro.setAnoPublicacion(modelLibros.getAnoPublicacion());
        libro.setIsbn(modelLibros.getIsbn());
        return libro;
    }
}

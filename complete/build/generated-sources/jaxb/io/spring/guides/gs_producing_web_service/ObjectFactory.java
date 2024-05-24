//
// Este archivo ha sido generado por Eclipse Implementation of JAXB v4.0.4 
// Visite https://eclipse-ee4j.github.io/jaxb-ri 
// Todas las modificaciones realizadas en este archivo se perderán si se vuelve a compilar el esquema de origen. 
//


package io.spring.guides.gs_producing_web_service;

import jakarta.xml.bind.annotation.XmlRegistry;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the io.spring.guides.gs_producing_web_service package. 
 * <p>An ObjectFactory allows you to programmatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {


    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: io.spring.guides.gs_producing_web_service
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetLibroRequest }
     * 
     * @return
     *     the new instance of {@link GetLibroRequest }
     */
    public GetLibroRequest createGetLibroRequest() {
        return new GetLibroRequest();
    }

    /**
     * Create an instance of {@link GetLibroResponse }
     * 
     * @return
     *     the new instance of {@link GetLibroResponse }
     */
    public GetLibroResponse createGetLibroResponse() {
        return new GetLibroResponse();
    }

    /**
     * Create an instance of {@link Libro }
     * 
     * @return
     *     the new instance of {@link Libro }
     */
    public Libro createLibro() {
        return new Libro();
    }

    /**
     * Create an instance of {@link CreateLibroRequest }
     * 
     * @return
     *     the new instance of {@link CreateLibroRequest }
     */
    public CreateLibroRequest createCreateLibroRequest() {
        return new CreateLibroRequest();
    }

    /**
     * Create an instance of {@link CreateLibroResponse }
     * 
     * @return
     *     the new instance of {@link CreateLibroResponse }
     */
    public CreateLibroResponse createCreateLibroResponse() {
        return new CreateLibroResponse();
    }

    /**
     * Create an instance of {@link UpdateLibroRequest }
     * 
     * @return
     *     the new instance of {@link UpdateLibroRequest }
     */
    public UpdateLibroRequest createUpdateLibroRequest() {
        return new UpdateLibroRequest();
    }

    /**
     * Create an instance of {@link UpdateLibroResponse }
     * 
     * @return
     *     the new instance of {@link UpdateLibroResponse }
     */
    public UpdateLibroResponse createUpdateLibroResponse() {
        return new UpdateLibroResponse();
    }

    /**
     * Create an instance of {@link DeleteLibroRequest }
     * 
     * @return
     *     the new instance of {@link DeleteLibroRequest }
     */
    public DeleteLibroRequest createDeleteLibroRequest() {
        return new DeleteLibroRequest();
    }

    /**
     * Create an instance of {@link DeleteLibroResponse }
     * 
     * @return
     *     the new instance of {@link DeleteLibroResponse }
     */
    public DeleteLibroResponse createDeleteLibroResponse() {
        return new DeleteLibroResponse();
    }

}

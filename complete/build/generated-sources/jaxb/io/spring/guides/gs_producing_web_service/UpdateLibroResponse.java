//
// Este archivo ha sido generado por Eclipse Implementation of JAXB v4.0.4 
// Visite https://eclipse-ee4j.github.io/jaxb-ri 
// Todas las modificaciones realizadas en este archivo se perderán si se vuelve a compilar el esquema de origen. 
//


package io.spring.guides.gs_producing_web_service;

import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.</p>
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.</p>
 * 
 * <pre>{@code
 * <complexType>
 *   <complexContent>
 *     <restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       <sequence>
 *         <element name="libro" type="{http://spring.io/guides/gs-producing-web-service}libro"/>
 *       </sequence>
 *     </restriction>
 *   </complexContent>
 * </complexType>
 * }</pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "libro"
})
@XmlRootElement(name = "updateLibroResponse")
public class UpdateLibroResponse {

    @XmlElement(required = true)
    protected Libro libro;

    /**
     * Obtiene el valor de la propiedad libro.
     * 
     * @return
     *     possible object is
     *     {@link Libro }
     *     
     */
    public Libro getLibro() {
        return libro;
    }

    /**
     * Define el valor de la propiedad libro.
     * 
     * @param value
     *     allowed object is
     *     {@link Libro }
     *     
     */
    public void setLibro(Libro value) {
        this.libro = value;
    }

}

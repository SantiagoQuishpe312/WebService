package com.example.producingwebservice;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;

import io.spring.guides.gs_producing_web_service.*;

@Endpoint
public class LibroEndpoint {
	private static final String NAMESPACE_URI = "http://spring.io/guides/gs-producing-web-service";

	@Autowired
	private LibrosService libroService;

	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getLibroRequest")
	@ResponsePayload
	public GetLibroResponse getLibro(@RequestPayload GetLibroRequest request) {
		GetLibroResponse response = new GetLibroResponse();
		libroService.findById(request.getId()).ifPresent(libro -> {
			response.setLibro(LibrosConverter.toLibro(libro));
		});
		return response;
	}

	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "createLibroRequest")
	@ResponsePayload
	public CreateLibroResponse createLibro(@RequestPayload CreateLibroRequest request) {
		CreateLibroResponse response = new CreateLibroResponse();
		ModelLibros modelLibros = LibrosConverter.toModelLibros(request.getLibro());
		response.setLibro(LibrosConverter.toLibro(libroService.save(modelLibros)));
		return response;
	}

	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "updateLibroRequest")
	@ResponsePayload
	public UpdateLibroResponse updateLibro(@RequestPayload UpdateLibroRequest request) {
		UpdateLibroResponse response = new UpdateLibroResponse();
		ModelLibros modelLibros = LibrosConverter.toModelLibros(request.getLibro());
		response.setLibro(LibrosConverter.toLibro(libroService.save(modelLibros)));
		return response;
	}

	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "deleteLibroRequest")
	@ResponsePayload
	public DeleteLibroResponse deleteLibro(@RequestPayload DeleteLibroRequest request) {
		DeleteLibroResponse response = new DeleteLibroResponse();
		libroService.deleteById(request.getId());
		response.setStatus("Libro eliminado");
		return response;
	}
}

package com.example.producingwebservice;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class LibrosService {
    @Autowired
    private DaoLibros libroRepository;

    public List<ModelLibros> findAll() {
        return libroRepository.findAll();
    }

    public Optional<ModelLibros> findById(Long id) {
        return libroRepository.findById(id);
    }

    public ModelLibros save(ModelLibros libro) {
        return libroRepository.save(libro);
    }

    public void deleteById(Long id) {
        libroRepository.deleteById(id);
    }
}

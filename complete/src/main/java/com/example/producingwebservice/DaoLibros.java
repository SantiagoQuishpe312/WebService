package com.example.producingwebservice;
import org.springframework.data.jpa.repository.JpaRepository;
public interface DaoLibros extends JpaRepository<ModelLibros, Long> {
}

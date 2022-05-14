package com.bakay.aprendendocomspring.controller;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestControllerAdvice;

@RestControllerAdvice
public class HellorController {
    @GetMapping(value = "/")
    public String getMethodName() {
        return "Olá muNOD Code";
    }

}

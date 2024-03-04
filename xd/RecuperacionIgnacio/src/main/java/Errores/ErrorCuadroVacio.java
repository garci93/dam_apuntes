/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Errores;

/**
 *
 * @author dam
 */
public class ErrorCuadroVacio extends Exception {

    public ErrorCuadroVacio() {
        super("El cuadro de texto no puede estar vacío");
    }
    
}

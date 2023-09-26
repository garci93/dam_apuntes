package Controlador;

import java.util.HashMap;

import Clases.Botes;
import Clases.Persona;
import Servicio.Servicio;
import Vista.Vista;

public class Controlador {


    private Servicio servicio;
    private Vista vista;

    public Controlador() {
        servicio = Servicio.getInstance();
        vista = new Vista();
    }


    public void iniciar() {
        servicio.asignarPersonasBote();
        vista.mostrarDatos(servicio.getPersonasBotes());
    }


}
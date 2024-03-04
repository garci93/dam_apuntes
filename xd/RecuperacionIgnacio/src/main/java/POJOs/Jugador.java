/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author dam
 */
public class Jugador {
    private int dorsal;
    private String nombre;
    private double puntos;
    private double rebotes;
    private double asistencias;

    public Jugador(int dorsal, String nombre, double puntos, double rebotes, double asistencias) {
        this.dorsal = dorsal;
        this.nombre = nombre;
        this.puntos = puntos;
        this.rebotes = rebotes;
        this.asistencias = asistencias;
    }

    public int getDorsal() {
        return dorsal;
    }

    public void setDorsal(int dorsal) {
        this.dorsal = dorsal;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getPuntos() {
        return puntos;
    }

    public void setPuntos(double puntos) {
        this.puntos = puntos;
    }

    public double getRebotes() {
        return rebotes;
    }

    public void setRebotes(double rebotes) {
        this.rebotes = rebotes;
    }

    public double getAsistencias() {
        return asistencias;
    }

    public void setAsistencias(double asistencias) {
        this.asistencias = asistencias;
    }
    
    
}

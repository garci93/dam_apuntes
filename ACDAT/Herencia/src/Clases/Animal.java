package Clases;

public abstract class Animal {
	private String nombre,especie;

	public Animal(String nombre, String especie) {
		this.nombre = nombre;
		this.especie = especie;
	}
	public Animal() {
		
	}
	
	public abstract void cualquiera();
	
	@Override
	public String toString() {
		return "nombre = " + nombre + ", especie= " + especie;
	}
	
	
}

package Clases;

import java.util.Date;
import java.util.Objects;

public class Pasajero extends Persona{
	private int numHabitacion;

	public Pasajero(String dni, Pais pais, Zona zona, String nombre, Minusvalia minusvalia, Date fecha,
			TipoPersona tipoPersona, int numHabitacion) {
		super(dni, pais, zona, nombre, minusvalia, fecha, tipoPersona);
		this.numHabitacion = numHabitacion;
	}

	public int getNumHabitacion() {
		return numHabitacion;
	}

	public void setNumHabitacion(int numHabitacion) {
		this.numHabitacion = numHabitacion;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + Objects.hash(numHabitacion);
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (!super.equals(obj))
			return false;
		if (getClass() != obj.getClass())
			return false;
		Pasajero other = (Pasajero) obj;
		return numHabitacion == other.numHabitacion;
	}

	@Override
	public String toString() {
		return "Pasajero [numHabitacion=" + numHabitacion + "]";
	}

}

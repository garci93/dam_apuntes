package Clases;

import java.util.Date;
import java.util.Objects;

public class Tripulacion extends Persona{
	private Responsabilidad responsabilidad;

	public Tripulacion(String dni, Pais pais, Zona zona, String nombre, Minusvalia minusvalia, Date fecha,
			TipoPersona tipoPersona, Responsabilidad responsabilidad) {
		super(dni, pais, zona, nombre, minusvalia, fecha, tipoPersona);
		this.responsabilidad = responsabilidad;
	}

	public Responsabilidad getResponsabilidad() {
		return responsabilidad;
	}

	public void setResponsabilidad(Responsabilidad responsabilidad) {
		this.responsabilidad = responsabilidad;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + Objects.hash(responsabilidad);
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
		Tripulacion other = (Tripulacion) obj;
		return responsabilidad == other.responsabilidad;
	}

	@Override
	public String toString() {
		return "Tripulacion [responsabilidad=" + responsabilidad + "]";
	}
	
	
}

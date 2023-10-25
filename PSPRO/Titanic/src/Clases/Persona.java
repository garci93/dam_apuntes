package Clases;

import java.util.Date;
import java.util.Objects;

public class Persona implements Comparable<Persona> {
	private String dni;
	private Pais pais;
	private Zona zona;
	private String nombre;
	private Minusvalia minusvalia;
	private Date fecha;
	private TipoPersona	tipoPersona;
	
	public Persona(String dni, Pais pais, Zona zona, String nombre, Minusvalia minusvalia, Date fecha,
			TipoPersona tipoPersona) {
		super();
		this.dni = dni;
		this.pais = pais;
		this.zona = zona;
		this.nombre = nombre;
		this.minusvalia = minusvalia;
		this.fecha = fecha;
		this.tipoPersona = tipoPersona;
	}

	public String getDni() {
		return dni;
	}

	public void setDni(String dni) {
		this.dni = dni;
	}

	public Pais getPais() {
		return pais;
	}

	public void setPais(Pais pais) {
		this.pais = pais;
	}

	public Zona getZona() {
		return zona;
	}

	public void setZona(Zona zona) {
		this.zona = zona;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public Minusvalia getMinusvalia() {
		return minusvalia;
	}

	public void setMinusvalia(Minusvalia minusvalia) {
		this.minusvalia = minusvalia;
	}

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public TipoPersona getTipoPersona() {
		return tipoPersona;
	}

	public void setTipoPersona(TipoPersona tipoPersona) {
		this.tipoPersona = tipoPersona;
	}

	@Override
	public int hashCode() {
		return Objects.hash(dni, fecha, minusvalia, nombre, pais, tipoPersona, zona);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Persona other = (Persona) obj;
		return Objects.equals(dni, other.dni) && Objects.equals(fecha, other.fecha) && minusvalia == other.minusvalia
				&& Objects.equals(nombre, other.nombre) && pais == other.pais && tipoPersona == other.tipoPersona
				&& zona == other.zona;
	}

	@Override
    public int compareTo(Persona p1) {
        int i = this.getPais().compareTo(p1.getPais());
        if(i==0) {
            i = this.getNombre().compareTo(p1.getNombre());
        }
        return i;
    }
	
}

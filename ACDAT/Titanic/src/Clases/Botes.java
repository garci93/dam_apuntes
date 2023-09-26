package Clases;

import java.util.Comparator;
import java.util.Objects;

public class Botes implements Comparable<Botes>{

	private static Integer num = 1;
	private Integer id;
	private Integer numPlazas;
	private Zona zona;
	
	
	public Botes(Integer numPlazas, Zona zona) {
		super();
		this.id = num++;
		this.numPlazas = numPlazas;
		this.zona = zona;
	}
	

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public Integer getNumPlazas() {
		return numPlazas;
	}

	public void setNumPlazas(Integer numPlazas) {
		this.numPlazas = numPlazas;
	}

	public Zona getZona() {
		return zona;
	}

	public void setZona(Zona zona) {
		this.zona = zona;
	}

	

	@Override
	public int hashCode() {
		return Objects.hash(id, numPlazas, zona);
	}


	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Botes other = (Botes) obj;
		return Objects.equals(id, other.id) && Objects.equals(numPlazas, other.numPlazas) && zona == other.zona;
	}


	@Override
	public String toString() {
		return "Bote [id=" + id + ", numPlazas=" + numPlazas + ", zona=" + zona + "]";
	}


	@Override
	public int compareTo(Botes b) {
		return this.getId().compareTo(b.getId());
	}
	
	
	
	
	
	
}
package Clases;

import java.util.Objects;

public class Botes {
	private static int id = 0;
	private int numPlazas;
	private Zona zona;
	
	public Botes(int numPlazas, Zona zona) {
		super();
		this.id++;
		this.numPlazas = numPlazas;
		this.zona = zona;
	}

	public static int getId() {
		return id;
	}

	public static void setId(int id) {
		Botes.id = id;
	}

	public int getNumPlazas() {
		return numPlazas;
	}

	public void setNumPlazas(int numPlazas) {
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
		return Objects.hash(numPlazas, zona);
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
		return numPlazas == other.numPlazas && zona == other.zona;
	}

	@Override
	public String toString() {
		return "Botes [numPlazas=" + numPlazas + ", zona=" + zona + "]";
	}
	
	
}

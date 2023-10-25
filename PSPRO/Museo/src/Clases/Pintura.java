package Clases;

import java.util.Objects;

public class Pintura extends Obra {
	private double alto;
	private double ancho;
	private String soporte;
	
	public Pintura(String titulo, int numeroInv, Artista autor, int anio, double alto, double ancho, String soporte) {
		super(titulo, numeroInv, autor, anio);
		this.alto = alto;
		this.ancho = ancho;
		this.soporte = soporte;
	}

	public double getAlto() {
		return alto;
	}

	public void setAlto(double alto) {
		this.alto = alto;
	}

	public double getAncho() {
		return ancho;
	}

	public void setAncho(double ancho) {
		this.ancho = ancho;
	}

	public String getSoporte() {
		return soporte;
	}

	public void setSoporte(String soporte) {
		this.soporte = soporte;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + Objects.hash(alto, ancho, soporte);
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
		Pintura other = (Pintura) obj;
		return Double.doubleToLongBits(alto) == Double.doubleToLongBits(other.alto)
				&& Double.doubleToLongBits(ancho) == Double.doubleToLongBits(other.ancho)
				&& Objects.equals(soporte, other.soporte);
	}

	@Override
	public String toString() {
		return super.toString() + "\nDimensiones: " + alto + " x " + ancho + " cm\nSoporte: " + soporte;
	}
	
	public void muestra(Pintura pi) {
		pi.toString();
	}
}

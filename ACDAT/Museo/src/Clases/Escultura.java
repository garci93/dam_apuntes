package Clases;

import java.util.Objects;

public class Escultura extends Obra {
	private String material;
	private double altura;
	
	public Escultura(String titulo, int numeroInv, Artista autor, int anio, String material, double altura) {
		super(titulo, numeroInv, autor, anio);
		this.material = material;
		this.altura = altura;
	}

	public String getMaterial() {
		return material;
	}

	public void setMaterial(String material) {
		this.material = material;
	}

	public double getAltura() {
		return altura;
	}

	public void setAltura(double altura) {
		this.altura = altura;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + Objects.hash(altura, material);
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
		Escultura other = (Escultura) obj;
		return Double.doubleToLongBits(altura) == Double.doubleToLongBits(other.altura)
				&& Objects.equals(material, other.material);
	}

	@Override
	public String toString() {
		return super.toString() + "\nMaterial: " + material + "\nAltura: " + altura + " m";
	}
	
	public void muestra(Escultura es) {
		es.toString();
	}
}

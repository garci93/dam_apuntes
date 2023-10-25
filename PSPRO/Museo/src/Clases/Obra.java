package Clases;

import java.util.Objects;

public abstract class Obra {
	private String titulo;
	private int numeroInv;
	private Artista autor;
	private int anio;
	
	public Obra(String titulo, int numeroInv, Artista autor, int anio) {
		this.titulo = titulo;
		this.numeroInv = numeroInv;
		this.autor = autor;
		this.anio = anio;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public int getNumeroInv() {
		return numeroInv;
	}

	public void setNumeroInv(int numeroInv) {
		this.numeroInv = numeroInv;
	}

	public Artista getAutor() {
		return autor;
	}

	public void setAutor(Artista autor) {
		this.autor = autor;
	}

	public int getAnio() {
		return anio;
	}

	public void setAnio(int anio) {
		this.anio = anio;
	}

	@Override
	public int hashCode() {
		return Objects.hash(anio, autor, numeroInv, titulo);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Obra other = (Obra) obj;
		return anio == other.anio && Objects.equals(autor, other.autor) && numeroInv == other.numeroInv
				&& Objects.equals(titulo, other.titulo);
	}

	@Override
	public String toString() {
		return "Título: " + titulo + "\nNúmero de inventario: " + numeroInv + "\nAutor: " + autor.getNombre() + "\nAño: " + anio;
	}
	
	public void muestra() {
		System.out.println(this.toString());
	}
}

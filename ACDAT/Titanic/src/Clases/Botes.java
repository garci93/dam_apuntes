package Clases;

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
}

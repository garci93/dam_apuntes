package Clases;

public class Reptil extends Animal{
	private double temperatura;

	public Reptil (String nombre, String especie, double temperatura) {
		super(nombre,especie);
		this.temperatura = temperatura;
	}
	
	@Override
	public void cualquiera() {
		// TODO Auto-generated method stub
		
	}
	
	public double temperaturaMortal() {
		return temperatura * 0.80; //si fuera un float habria que poner 0.80F
	}

	@Override
	public String toString() {
		return ", temperatura= " + temperatura + "]";
	}
}

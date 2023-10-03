package Clases;

public class Mamifero extends Animal{
	private Integer mamas;
	
	Mamifero (String nombre, String especie, Integer mamas)
	{
		super (nombre,especie);
		this.mamas = mamas;
	}

	@Override
	public String toString() {
		return super.toString() + ", mamas= " + mamas;
	}

	@Override
	public void cualquiera() {
		
	}
	
	
}

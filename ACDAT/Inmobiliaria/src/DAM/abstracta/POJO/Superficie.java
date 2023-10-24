package DAM.abstracta.POJO;

public class Superficie extends Inmueble {
	private float precioPorM2;

	public Superficie(String ubicacion, float area, float precioPorM2) {
		super(ubicacion, area);
		this.precioPorM2 = precioPorM2;
	}
	
	public float getPrecioTotal() {
		//TODO
		return 0;
	}

	public float getPrecioPorM2() {
		return precioPorM2;
	}

	public void setPrecioPorM2(float precioPorM2) {
		this.precioPorM2 = precioPorM2;
	}
}
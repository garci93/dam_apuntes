package DAM.abstracta.POJO;

public class Inmueble {
	
	private String ubicacion;
	private float area;
	
	public Inmueble(String ubicacion, float area) {
		super();
		this.ubicacion = ubicacion;
		this.area = area;
	}
	
	public Inmueble() {
		super();
		// TODO Auto-generated constructor stub
	}

	public String getUbicacion() {
		return ubicacion;
	}
	public void setUbicacion(String ubicacion) {
		this.ubicacion = ubicacion;
	}
	public float getArea() {
		return area;
	}
	public void setArea(float area) {
		this.area = area;
	}

	@Override
	public String toString() {
		return "Inmueble [ubicacion=" + ubicacion + ", area=" + area + "]";
	}
}
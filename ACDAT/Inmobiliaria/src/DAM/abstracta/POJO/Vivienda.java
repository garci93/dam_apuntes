package DAM.abstracta.POJO;

public class Vivienda extends Construccion {
	private double precio;
	private int numHabitaciones;
	private int piso;
	
	public double getPrecio() {
		return precio;
	}
	public void setPrecio(double precio) {
		this.precio = precio;
	}
	public int getNumHabitaciones() {
		return numHabitaciones;
	}
	public void setNumHabitaciones(int numHabitaciones) {
		this.numHabitaciones = numHabitaciones;
	}
	public int getPiso() {
		return piso;
	}
	public void setPiso(int piso) {
		this.piso = piso;
	}
	
}

package DAM.abstracta.POJO;

import DAM.abstracta.enums.TipoConstruccion;
import DAM.abstracta.interfaces.IVenta;

public class Vivienda extends Construccion implements IVenta{
	private float precio;
	private int numHabitaciones;
	private String piso;
	
	public Vivienda(String ubicacion, float area, TipoConstruccion tipoConst, float precio, int numHabitaciones,
			String piso) {
		super(ubicacion, area, tipoConst);
		this.precio = precio;
		this.numHabitaciones = numHabitaciones;
		this.piso = piso;
	}
	public double getPrecio() {
		return precio;
	}
	
	public void setPrecio(float precio) {
		this.precio = precio;
	}
	
	public int getNumHabitaciones() {
		return numHabitaciones;
	}
	
	public void setNumHabitaciones(int numHabitaciones) {
		this.numHabitaciones = numHabitaciones;
	}
	
	public String getPiso() {
		return piso;
	}
	
	public void setPiso(String piso) {
		this.piso = piso;
	}
	
	@Override
	public String toString() {
		return "Vivienda [precio=" + precio + ", numHabitaciones=" + numHabitaciones + ", piso=" + piso + "]";
	}
	@Override
	public void vender() {
		// TODO Auto-generated method stub
		
	}
	
}

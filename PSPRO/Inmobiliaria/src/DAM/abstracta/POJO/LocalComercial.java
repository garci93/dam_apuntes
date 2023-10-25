package DAM.abstracta.POJO;

import DAM.abstracta.enums.TipoConstruccion;
import DAM.abstracta.interfaces.IAlquiler;

public class LocalComercial extends Construccion implements IAlquiler{
	private double precioPorM2;

	public LocalComercial(String ubicacion, float area, TipoConstruccion tipoConst, double precioPorM2) {
		super(ubicacion, area, tipoConst);
		this.precioPorM2 = precioPorM2;
	}
	
	public float getPrecioTotal() {
		//TODO
		return 0;
	}
	
	public double getPrecioPorM2() {
		return precioPorM2;
	}

	public void setPrecioPorM2(double precioPorM2) {
		this.precioPorM2 = precioPorM2;
	}

	@Override
	public String toString() {
		return "LocalComercial [precioPorM2=" + precioPorM2 + "]";
	}

	@Override
	public void alquilar() {
		// TODO Auto-generated method stub
		
	}
}

package DAM.abstracta.POJO;

import DAM.abstracta.enums.ZonaSolar;
import DAM.abstracta.interfaces.IVenta;

public class Solar extends Superficie implements IVenta{
	private ZonaSolar zona;

	public Solar(String ubicacion, float area, float precioPorM2, ZonaSolar zona) {
		super(ubicacion, area, precioPorM2);
		this.zona = zona;
	}

	public ZonaSolar getZona() {
		return zona;
	}

	public void setZona(ZonaSolar zona) {
		this.zona = zona;
	}

	@Override
	public String toString() {
		return "Solar [zona=" + zona + "]";
	}

	@Override
	public void vender() {
		// TODO Auto-generated method stub
		
	}
}
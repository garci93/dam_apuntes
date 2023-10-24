package DAM.abstracta.POJO;

import DAM.abstracta.enums.TipoPlaza;
import DAM.abstracta.interfaces.IAlquiler;

public class PlazaGaraje extends Superficie implements IAlquiler{
	private TipoPlaza tipo;

	public PlazaGaraje(String ubicacion, float area, float precioPorM2, TipoPlaza tipo) {
		super(ubicacion, area, precioPorM2);
		this.tipo = tipo;
	}

	public TipoPlaza getGaraje() {
		return tipo;
	}

	public void setGaraje(TipoPlaza tipo) {
		this.tipo = tipo;
	}

	@Override
	public String toString() {
		return "PlazaGaraje [tipo=" + tipo + "]";
	}

	@Override
	public void alquilar() {
		// TODO Auto-generated method stub
		
	}
}

package DAM.abstracta.POJO;

import DAM.abstracta.enums.TipoPlaza;

public class PlazaGaraje extends Superficie{
	private TipoPlaza tipo;

	public TipoPlaza getGaraje() {
		return tipo;
	}

	public void setGaraje(TipoPlaza tipo) {
		this.tipo = tipo;
	}
	
	
}

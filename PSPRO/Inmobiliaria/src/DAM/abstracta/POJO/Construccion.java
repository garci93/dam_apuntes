package DAM.abstracta.POJO;

import DAM.abstracta.enums.TipoConstruccion;

public class Construccion extends Inmueble{
	private TipoConstruccion tipoConst;

	public Construccion(String ubicacion, float area, TipoConstruccion tipoConst) {
		super(ubicacion, area);
		this.tipoConst = tipoConst;
	}

	public TipoConstruccion getTipoConst() {
		return tipoConst;
	}

	public void setTipoConst(TipoConstruccion tipoConst) {
		this.tipoConst = tipoConst;
	}

	@Override
	public String toString() {
		return "Construccion [tipoConst=" + tipoConst + "]";
	}
	
	
}
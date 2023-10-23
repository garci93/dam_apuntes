package DAM.abstracta.POJO;

import DAM.abstracta.enums.TipoConstruccion;

public class Construccion extends Inmueble{
	private TipoConstruccion tipoConst;

	public TipoConstruccion getTipoConst() {
		return tipoConst;
	}

	public void setTipoConst(TipoConstruccion tipoConst) {
		this.tipoConst = tipoConst;
	}
}